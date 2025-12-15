namespace BattleChat_Arena.Models
{
    public class Attack : Command
    {
        public string Name { get; set; }

        public override bool CanExecute(Player executor, Player target)
        {
            if (executor.CanExecuteCommand() == false || executor.Energy < 10 || target.CurrentState == PlayerState.Armored)
                return false;

            return true;
        }

        public override void Execute(Player executor, Player target)
        {
            target.Health -= 10;
            executor.Energy -= 10;
        }
    }
}
