using Calculator.App.Contracts;
using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Commands.History
{
    public class ClearHistoryCommand : ICommand
    {
        private IHistoryController historyController;

        public ClearHistoryCommand(IHistoryController historyController, IList<string> args)
        {
            this.historyController = historyController;
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            this.historyController.ClearHistory();
            return Constants.ClearedHistory;
        }
    }
}
