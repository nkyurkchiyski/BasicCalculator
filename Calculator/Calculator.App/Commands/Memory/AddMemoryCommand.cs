using Calculator.App.Contracts;
using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Commands.Memory
{
    public class AddMemoryCommand : ICommand
    {
        private IMemoryController memoryController;

        public AddMemoryCommand(IMemoryController memoryController, IList<string> args)
        {
            this.memoryController = memoryController;
            this.Arguments = args;
        }

        public IList<string> Arguments { get; }

        public string Execute()
        {
            this.memoryController.AddMemory(this.Arguments[0]);
            return string.Format(Constants.ChangeMemory, this.memoryController.Memory);
        }
    }
}
