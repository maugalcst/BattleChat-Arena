using BattleChat_Arena.Core.Interfaces;
using BattleChat_Arena.Models;

namespace BattleChat_Arena.Services
{
    public class GameService
    {
        public bool TryExecuteCommand(ICommand command, Player executor, Player target)
        {
            if (command.CanExecute(executor, target) == false)
                return false;

            command.Execute(executor, target);

            executor.ApplyStateEffect();
            target.ApplyStateEffect();

            return true;
            
        }
    }
}
