using System;

namespace Vermaat.Crm.Specflow.Commands
{
    public abstract class ApiOnlyCommandFunc<TResult> : ICommandFunc<TResult>
    {
        protected readonly ICrmTestingContext _crmContext;

        public ApiOnlyCommandFunc(ICrmTestingContext crmContext)
        {
            _crmContext = crmContext;
        }

        public abstract TResult Execute();

        public TResult Execute(CommandAction commandAction = CommandAction.Default)
        {
            if (commandAction == CommandAction.ForceBrowser)
                throw new TestExecutionException(Constants.ErrorCodes.BROWSER_OT_SUPPORTED_FOR_API_TEST);
            return Execute();
        }
    }

    public abstract class ApiOnlyCommand : ICommand
    {
        protected readonly ICrmTestingContext _crmContext;

        public ApiOnlyCommand(ICrmTestingContext crmContext)
        {
            _crmContext = crmContext;
        }

        public abstract void Execute();

        public void Execute(CommandAction commandAction = CommandAction.Default)
        {
            if (commandAction == CommandAction.ForceBrowser)
                throw new TestExecutionException(Constants.ErrorCodes.BROWSER_OT_SUPPORTED_FOR_API_TEST);
            Execute();
        }
    }


}
