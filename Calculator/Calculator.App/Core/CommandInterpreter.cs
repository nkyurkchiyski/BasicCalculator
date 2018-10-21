using Calculator.App.Contracts;
using Calculator.App.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Calculator.App.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {

        public CommandInterpreter(IHistoryController historyController, IMemoryController memoryController)
        {
            this.HistoryController = historyController;
            this.MemoryController = memoryController;
        }

        public IHistoryController HistoryController { get; }

        public IMemoryController MemoryController { get; }

        public string ProcessCommand(IList<string> args)
        {
            string result = "";
            try
            {
                List<string> arguments = args.ToList().GetRange(1, args.Count - 1);
                string type = args[0];

                Type classType = Assembly.GetExecutingAssembly()
                    .GetTypes().FirstOrDefault(t => t.Name == type + Constants.CommandSuffix);

                var ctors = classType.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
                var fields = classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

                ICommand command = null;
                if (fields.Length == 1)
                {
                    command = (ICommand)ctors[0].Invoke(new object[] { arguments });
                }
                else if (fields[0].FieldType == typeof(IHistoryController))
                {
                    command = (ICommand)ctors[0].Invoke(new object[] { this.HistoryController, arguments });
                }
                else if (fields[0].FieldType == typeof(IMemoryController))
                {
                    command = (ICommand)ctors[0].Invoke(new object[] { this.MemoryController, arguments });
                }
                result = command.Execute();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
