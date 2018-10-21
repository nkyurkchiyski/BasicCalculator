using Calculator.App.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands.History
{
    public class RetrieveHistoryCommand : ICommand
    {
        private IHistoryController historyController;

        public RetrieveHistoryCommand(IHistoryController historyController, IList<string> args)
        {
            this.historyController = historyController;
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            string result = this.historyController.RetrieveHistory();
            return result;
        }
    }
}
