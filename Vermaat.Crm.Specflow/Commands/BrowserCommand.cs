using System;
using TechTalk.SpecFlow;

namespace Vermaat.Crm.Specflow.Commands
{
    public abstract class BrowserCommandFunc<TResult> : ICommandFunc<TResult>
    {
        protected readonly ICrmTestingContext _crmContext;
        protected readonly ISeleniumTestingContext _seleniumContext;

        public BrowserCommandFunc(ICrmTestingContext crmContext, ISeleniumTestingContext seleniumContext)
        {
            _crmContext = crmContext;
            _seleniumContext = seleniumContext;
        }

        public TResult Execute(CommandAction commandAction = CommandAction.Default)
        {
            var actionToUse = commandAction == CommandAction.Default ?
                HelperMethods.GetPreferredCommandActionFromTarget(_crmContext) : commandAction;

            switch(actionToUse)
            {
                case CommandAction.ForceApi:
                case CommandAction.PreferApi:
                    return ExecuteApi();
                case CommandAction.PreferBrowser:
                case CommandAction.ForceBrowser:
                    return ExecuteBrowser();
                default:
                    throw new TestExecutionException(Constants.ErrorCodes.UNKNOWN_TAG);
            }
        }

        protected abstract TResult ExecuteApi();
        protected abstract TResult ExecuteBrowser();
    }

    public abstract class BrowserCommand : ICommand
    {
        protected readonly ICrmTestingContext _crmContext;
        protected readonly ISeleniumTestingContext _seleniumContext;

        public BrowserCommand(ICrmTestingContext crmContext, ISeleniumTestingContext seleniumContext)
        {
            _crmContext = crmContext;
            _seleniumContext = seleniumContext;
        }

        public void Execute(CommandAction commandAction = CommandAction.Default)
        {
            var actionToUse = commandAction == CommandAction.Default ?
                HelperMethods.GetPreferredCommandActionFromTarget(_crmContext) : commandAction;

            switch (actionToUse)
            {
                case CommandAction.ForceApi:
                case CommandAction.PreferApi:
                    ExecuteApi(); break;
                case CommandAction.PreferBrowser:
                case CommandAction.ForceBrowser:
                    ExecuteBrowser(); break;
                default:
                    throw new TestExecutionException(Constants.ErrorCodes.UNKNOWN_TAG);
            }
        }

        protected abstract void ExecuteApi();
        protected abstract void ExecuteBrowser();
    }
}
