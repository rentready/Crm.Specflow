using global::System.Collections.Specialized;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Vermaat.Crm.Specflow
{
    public static class ConfigurationManager
    {
        public static volatile IConfiguration s_configSystem;

        // Initialization state
        private static volatile InitState s_initState = InitState.NotStarted;
        private static readonly object s_initLock = new object();
        private static volatile Exception s_initError;

        public static Dictionary<string, string> AppSettings
        {
            get
            {
                var section = GetSection("AppSettings");
                if (section is null)
                {
                    // If config is null or not the type we expect, the declaration was changed.
                    // Treat it as a configuration error.
                    throw new InvalidOperationException("Failed to retrieve configuraiton.");
                }

                return section;
            }
        }

        private static void EnsureConfigurationSystem()
        {
            lock (s_initLock)
            {
                if (s_initState >= InitState.Usable) return;

                s_initState = InitState.Started;
                try
                {
                    try
                    {
                        s_configSystem = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddJsonFile("secrets.json", optional: true, reloadOnChange: true)
                            .Build();

                        s_initState = InitState.Usable;
                    }
                    catch (Exception e)
                    {
                        s_initError =
                            new InvalidOperationException("Failed to initialize config.", e);
                        throw s_initError;
                    }
                }
                catch
                {
                    s_initState = InitState.Completed;
                    throw;
                }
            }
        }

        private static void PrepareConfigSystem()
        {
            // Ensure the configuration system is usable.
            if (s_initState < InitState.Usable) EnsureConfigurationSystem();

            // If there was an initialization error, throw it.
            if (s_initError != null) throw s_initError;
        }

        public static Dictionary<string, string> GetSection(string sectionName)
        {
            // Avoid unintended AV's by ensuring sectionName is not empty.
            // For compatibility, we cannot throw an InvalidArgumentException.
            if (string.IsNullOrEmpty(sectionName)) return null;

            PrepareConfigSystem();

            return s_configSystem.GetSection(sectionName).GetChildren().ToDictionary(x => x.Key, x => x.Value);
        }

        private enum InitState
        {
            // Initialization has not yet started.
            NotStarted = 0,

            // Initialization has started.
            Started,

            // The config system can be used, but initialization is not yet complete.
            Usable,

            // The config system has been completely initialized.
            Completed
        };
    }
}