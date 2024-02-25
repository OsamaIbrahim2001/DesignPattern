namespace CommandPattern.Core.Commands
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
        }
    }
}
