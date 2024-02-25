namespace UndoRedo.Core.Commands
{
    internal class CommandInvocker
    {
        private List<ICommand> commands = new();
        private Stack<ICommand> _executedCommands = new();
        private Stack<ICommand> _unExecutedCommands = new();
        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void ExecudeCommands()
        {
            foreach (ICommand command in commands)
            {
                ExecudeCommand(command);
            }
            ClearCommands();
        }
        public void ExecudeCommand(ICommand command)
        {
            command.Execute();
            _executedCommands.Push(command);
        }

        public void Undo()
        {
            var command= _executedCommands.Pop();
            _unExecutedCommands.Push(command);
            command.Undo();
        }
        public void Redo()
        {
            var command= _unExecutedCommands.Pop();
            ExecudeCommand(command);
        }

        public void ClearCommands() => commands.Clear();

        public IEnumerable<ICommand> GetCommands() => commands.AsReadOnly();
    }
}
