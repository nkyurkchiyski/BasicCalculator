using Calculator.App.Contracts;
using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Commands.Memory
{
    public class ClearMemoryCommand : ICommand
    {
        private IMemoryController memoryController;

        public ClearMemoryCommand(IMemoryController memoryController, IList<string> args)
        {
            this.memoryController = memoryController;
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            this.memoryController.ClearMemory();
            return Constants.ClearedMemory;
        }
    }
}
