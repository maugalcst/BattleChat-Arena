using BattleChat_Arena.Models;

namespace BattleChat_Arena
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public decimal Energy { get; set; }
        public PlayerState CurrentState { get; set; }
        public int StateTurnsRemaining { get; set; }
        public bool IsConnected { get; set; }

        public void ApplyStateEffect()
        {
            if (StateTurnsRemaining <= 0)
            {
                CurrentState = PlayerState.Normal;
                return;
            }
            
            switch (CurrentState)
            {
                case PlayerState.Burning:
                    Health -= 5;
                    break;

                case PlayerState.Confused:
                    break;

                case PlayerState.Armored:
                    break;

            }

            StateTurnsRemaining--;

            if (StateTurnsRemaining <= 0)
            {
                CurrentState = PlayerState.Normal;
            }
                    
        }

        public bool CanExecuteCommand()
        {
            if (CurrentState == PlayerState.Freezed) 
                return false;

            else if (CurrentState == PlayerState.Armored && StateTurnsRemaining == 2)
                return false;

            else
                return true; 
        }

    }
}
