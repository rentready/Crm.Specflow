using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Vermaat.Crm.Specflow
{
    [Binding]
    public class CrmTestingContext : ICrmTestingContext
    {

        public RecordBuilder RecordBuilder { get; }
        public TableConverter TableConverter { get; }

        public CommandProcessor CommandProcessor { get; set; }

        public AliasedRecordCache RecordCache { get; }

        private readonly string[] _targets;

        public CrmTestingContext(ScenarioContext scenarioContext)
        {
            RecordBuilder = new RecordBuilder(this);
            TableConverter = new TableConverter(this);
            CommandProcessor = new CommandProcessor(scenarioContext);
            RecordCache = new AliasedRecordCache(GlobalTestingContext.Metadata);

            var targets = ConfigurationManager.AppSettings["Target"]?
                .ToLower()
                .Split('_')
                .Select(splitted => splitted.Trim())
                .ToList() ?? new System.Collections.Generic.List<string>();

            scenarioContext.TryGetValue("Target", out var scenarioTarget);
            if (scenarioTarget != null)
            {
                targets.Add(Convert.ToString(scenarioTarget).ToLower());
            }

            _targets = targets.ToArray();
        }

        public bool IsTarget(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
                return false;

            return _targets.Contains(target.ToLower());
        }

    }
}
