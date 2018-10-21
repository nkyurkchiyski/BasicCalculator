using Calculator.App.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Commands.Memory
{
    public class RetrieveMemoryCommand : ICommand
    {
        private IMemoryController memoryController;

        public RetrieveMemoryCommand(IMemoryController memoryController, IList<string> args)
        {
            this.memoryController = memoryController;
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            string num = this.memoryController.Memory.ToString();
            return num;
        }

    }
}
