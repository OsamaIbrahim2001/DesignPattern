using UndoRedo.Core.Commands;

namespace UndoRedo.Core.Macro
{
    internal class MacroSotrage
    {
        public static MacroSotrage Instance { get; } = new();
        private MacroSotrage()
        {
        }
        private readonly List<Macro> _macros=new();

        public void CreateMacro(IEnumerable<ICommand> commands) {
            var macro = new Macro(_macros.Count + 1, commands.ToList());
            _macros.Add(macro);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Macro #{macro.Id} Saved.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public IEnumerable<Macro> GetMacros() => _macros.AsReadOnly();

        public Macro GetMacro(int id) => _macros.First(m => m.Id == id);
    }
}
