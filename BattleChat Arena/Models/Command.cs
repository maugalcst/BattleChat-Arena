using BattleChat_Arena.Core.Interfaces;

namespace BattleChat_Arena.Models
{
    public abstract class Command : ICommand
    {
        public string Name { get; set; }

        public abstract bool CanExecute(Player executor, Player target);
        public abstract void Execute(Player executor, Player target);
    }
}
