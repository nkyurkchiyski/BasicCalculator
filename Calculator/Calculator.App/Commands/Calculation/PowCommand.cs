using Calculator.App.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Commands.Calculation
{
    public class PowCommand : ICommand
    {
        public PowCommand(IList<string> args)
        {
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            double firstOperand = double.Parse(this.Arguments[0]);
            double secondOperand = double.Parse(this.Arguments[1]);
            decimal result = (decimal)Math.Pow(firstOperand, secondOperand);
            return Math.Round(result).ToString();
        }
    }
}
