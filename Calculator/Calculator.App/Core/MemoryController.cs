using Calculator.App.Contracts;
using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Core
{
    public class MemoryController : IMemoryController
    {
        private decimal memory;

        public MemoryController()
        {
            this.memory = 0;
        }

        public decimal Memory => this.memory;

        public void AddMemory(string input)
        {
            if (!decimal.TryParse(input, out decimal number))
            {
                throw new ArgumentException(Constants.InvalidMemoryEntry);
            }
            this.memory += number;
        }

        public void SubtractMemory(string input)
        {
            if (!decimal.TryParse(input, out decimal number))
            {
                throw new ArgumentException(Constants.InvalidMemoryEntry);
            }
            this.memory -= number;
        }

        public void ClearMemory()
        {
            this.memory = 0;
        }


    }
}
