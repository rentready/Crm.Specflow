using System;

namespace Vermaat.Crm.Specflow.Commands
{
    public abstract class BrowserOnlyCommandFunc<TResult> : ICommandFunc<TResult>
    {
        protected readonly ICrmTestingContext _crmContext;
        protected readonly SeleniumTestingContext _seleniumContext;

        public BrowserOnlyCommandFunc(ICrmTestingContext crmContext, SeleniumTestingContext seleniumContext)
        {
            _crmContext = crmContext;
            _seleniumContext = seleniumContext;
        }

        public abstract TResult Execute();

        public TResult Execute(CommandAction commandAction = CommandAction.Default)
        {
            if (commandAction == CommandAction.ForceApi)
                throw new TestExecutionException(Constants.ErrorCodes.API_NOT_SUPPORTED_FOR_BROWSER_ONLY_COMMANDS);
            return Execute();
        }
    }


    public abstract class BrowserOnlyCommand : ICommand
    {
        protected readonly ICrmTestingContext _crmContext;
        protected readonly SeleniumTestingContext _seleniumContext;

        public BrowserOnlyCommand(ICrmTestingContext crmContext, SeleniumTestingContext seleniumContext)
        {
            _crmContext = crmContext;
            _seleniumContext = seleniumContext;
        }

        public abstract void Execute();

        public void Execute(CommandAction commandAction = CommandAction.Default)
        {
            if (commandAction == CommandAction.ForceApi)
                throw new TestExecutionException(Constants.ErrorCodes.API_NOT_SUPPORTED_FOR_BROWSER_ONLY_COMMANDS);
            Execute();
        }
    }
}
