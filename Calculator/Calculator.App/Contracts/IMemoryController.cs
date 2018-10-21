using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Contracts
{
    public interface IMemoryController
    {
        decimal Memory { get; }

        void AddMemory(string input);

        void SubtractMemory(string input);

        void ClearMemory();

    }
}
