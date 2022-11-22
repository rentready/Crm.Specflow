﻿using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vermaat.Crm.Specflow.EasyRepro;

namespace Vermaat.Crm.Specflow.Connectivity
{
    public abstract class CrmConnection
    {
        private ICrmService _service;

        public CrmConnection(string identifier)
        {
            Identifier = $"{GetType().Name}_{identifier}";
        }

        public abstract ICrmService CreateCrmServiceInstance();
        public abstract BrowserLoginDetails GetBrowserLoginInformation();

        public ICrmService Service 
        {
            get 
            {
                if (_service == null)
                    _service = CreateCrmServiceInstance();
                return _service;
            } 
            set { _service = value; }
        }

        public string Identifier { get; }
    }
}
