using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Contracts
{
    public interface ICommand
    {
        IList<string> Arguments { get; }

        string Execute();
    }
}
