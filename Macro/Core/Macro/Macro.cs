using UndoRedo.Core.Commands;

namespace UndoRedo.Core.Macro
{
    internal class Macro
    {
        public Macro(int id, IEnumerable<ICommand> commands)
        {
            Id = id;
            Commands = commands;
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public IEnumerable<ICommand> Commands { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
