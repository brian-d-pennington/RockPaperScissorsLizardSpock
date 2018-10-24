using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    abstract class PlayerModel
    {
        public string playerName;
        public int playerScore;

        public PlayerModel()
        {

        }

        public abstract void PlayerMakesMove();
        
    }
}
