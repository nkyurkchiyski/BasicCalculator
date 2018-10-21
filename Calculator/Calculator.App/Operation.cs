using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operation
    {
        private char typeOperation;
        private string firstOperand;
        private string secondOperand;
        private string result;

        public Operation(char typeOperation, string firstOperand, string secondOperand, string result)
        {
            this.typeOperation = typeOperation;
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;
            this.result = result;
        }

        public char Type { get => this.typeOperation; }

        public string FirstOperand { get => this.firstOperand; }

        public string SecondOperand { get => this.secondOperand; }

        public string Result { get => this.result; }

        public static Operation Parse(string input)
        {
            string[] args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length != 4)
            {
                throw new ArgumentException(Constants.InvalidOperationArgumentsCount);
            }

            if (!char.TryParse(args[1], out char type))
            {
                throw new ArgumentException(Constants.InvalidOperationTypeArgument);
            }

            Operation operation = new Operation(type, args[0], args[2], args[3]);

            return operation;
        }

        public override string ToString()
        {
            return $"{this.firstOperand} {this.typeOperation} {this.secondOperand} {this.result}";
        }
    }
}
