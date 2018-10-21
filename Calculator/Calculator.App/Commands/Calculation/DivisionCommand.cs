using Calculator.App.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Commands.Calculation
{
    public class DivisionCommand : ICommand
    {
        public DivisionCommand(IList<string> args)
        {
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            decimal firstOperand = decimal.Parse(this.Arguments[0]);
            decimal secondOperand = decimal.Parse(this.Arguments[1]);
            decimal result = firstOperand / secondOperand;
            return Math.Round(result).ToString();
        }
    }
}
