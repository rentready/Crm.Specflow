using Microsoft.Dynamics365.UIAutomation.Browser;
using Vermaat.Crm.Specflow.EasyRepro;

namespace Vermaat.Crm.Specflow
{
    public interface ISeleniumTestingContext
    {
        BrowserOptions BrowserOptions { get; }
        string CurrentApp { get; set; }
        bool IsLoggedIn { get; set; }

        void EndCurrentBrowserSession();
        UCIBrowser GetBrowser();
    }
}