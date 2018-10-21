using Calculator.App.Contracts;
using Calculator.App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.App
{
    public class BasicCalculator
    {
        private ICommandInterpreter commandInterpreter;
        private IHistoryController historyController;
        private IMemoryController memoryController;

        public BasicCalculator()
        {
            this.historyController = new HistoryController();
            this.memoryController = new MemoryController();
            this.commandInterpreter = new CommandInterpreter(this.historyController, this.memoryController);
        }

        public string ProcessInput(IList<string> args)
        {
            string output = this.commandInterpreter.ProcessCommand(args);
            return output.Trim();
        }

    }
}
