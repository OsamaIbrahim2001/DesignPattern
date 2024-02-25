namespace UndoRedo.Core.Commands
{
    internal class CommandInvocker
    {
        private List<ICommand> commands = new();
        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void ExecudeCommands()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
            ClearCommands();
        }

        public void ClearCommands() => commands.Clear();

        public IEnumerable<ICommand> GetCommands() => commands.AsReadOnly();
    }
}
