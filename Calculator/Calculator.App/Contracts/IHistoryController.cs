using System.Collections.Generic;

namespace Calculator.App.Contracts
{
    public interface IHistoryController
    {
        IReadOnlyCollection<Operation> History { get; }

        void AddOperation(IList<string> args);

        void ClearHistory();

        string RetrieveHistory();
    }
}