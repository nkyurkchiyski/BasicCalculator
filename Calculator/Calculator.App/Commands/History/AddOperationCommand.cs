using Calculator.App.Contracts;
using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Commands.History
{
    public class AddOperationCommand : ICommand
    {
        private IHistoryController historyController;

        public AddOperationCommand(IHistoryController historyController, IList<string> args)
        {
            this.historyController = historyController;
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            this.historyController.AddOperation(this.Arguments);
            return string.Format(Constants.HistoryStatus, this.historyController.History.Count);
        }
    }
}
