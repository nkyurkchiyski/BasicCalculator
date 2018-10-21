using Calculator.App.Contracts;
using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.App.Core
{
    public class HistoryController : IHistoryController
    {
        private char[] symbols = new char[] { '+', '-', '/', '*', '%', '^' };

        private List<Operation> history;

        public HistoryController()
        {
            this.history = new List<Operation>();
        }

        public IReadOnlyCollection<Operation> History => this.history;

        public void AddOperation(IList<string> args)
        {
            char typeOperation = TextToSymbol(args[0]);

            if (!symbols.Contains(typeOperation))
            {
                throw new ArgumentException(Constants.InvalidTypeOperationAdded);
            }

            Operation operation = new Operation(typeOperation, args[1], args[2], args[3]);

            this.history.Add(operation);
        }

        public void ClearHistory()
        {
            this.history.Clear();
        }

        public string RetrieveHistory()
        {
            if (this.history.Count == 0)
            {
                throw new InvalidOperationException(Constants.EmptyHistory);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.history.Count; i++)
            {
                sb.AppendLine(this.history[i].ToString());
            }

            return sb.ToString().Trim();
        }

        private char TextToSymbol(string text)
        {
            char symbol = ' ';
            switch (text)
            {
                case "Addition": symbol = '+'; break;
                case "Subtraction": symbol = '-'; break;
                case "Division": symbol = '/'; break;
                case "Multiplication": symbol = '*'; break;
                case "Percent": symbol = '%'; break;
                case "Pow": symbol = '^'; break;
            }

            return symbol;

        }
    }
}
