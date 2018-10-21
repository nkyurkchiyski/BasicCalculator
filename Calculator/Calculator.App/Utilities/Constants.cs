using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.App.Utilities
{
    public static class Constants
    {
        public const string ChangeMemory = "Current memory: {0}";
        
        public const string ClearedMemory = "Memory cleared";

        public const string HistoryStatus = "Operations done: {0}";

        public const string ClearedHistory = "History cleared";

        public const string CommandSuffix = "Command";

        public const string InvalidHistoryEntry = "ERROR: You can only add operations to history";

        public const string InvalidTypeOperationAdded = "ERROR: Invalid type of operation added";

        public const string InvalidMemoryEntry = "ERROR: You can only add/subtract numbers to memory";

        public const string EmptyHistory = "ERROR: The operation history is empty";

        public const string InvalidOperationArgumentsCount = "ERROR: Invalid operation members count";

        public const string InvalidOperationTypeArgument = "ERROR: Invalid operation type";

    }
}
