using BattleChat_Arena.Models;

namespace BattleChat_Arena.Core.Interfaces
{
    public interface ICommand
    {
        string Name { get; }
        bool CanExecute(Player executor, Player target);
        void Execute(Player executor, Player target);
    }
}
