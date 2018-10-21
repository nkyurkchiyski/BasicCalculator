using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Contracts
{
    public interface ICommandInterpreter
    {
        IHistoryController HistoryController { get; }

        IMemoryController MemoryController { get; }

        string ProcessCommand(IList<string> args);
    }
}
