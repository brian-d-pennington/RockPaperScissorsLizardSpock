using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    abstract class PlayerModel
    {

        public string makesMove;
        public int score;


        public PlayerModel()
        {
         
        }

        public abstract void PlayerMakesMove();
        
    }
}
