using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    abstract class PlayerModel
    {
        public string humanPlayerOneName;
        public string humanPlayerTwoName;
        public string compPlayerOneName;
        public string compPlayerTwoName;
        public int playerScore;

        public PlayerModel()
        {

        }

        public abstract void PlayerMakesMove();
        
    }
}
