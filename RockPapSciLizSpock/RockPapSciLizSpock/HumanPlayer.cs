using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class HumanPlayer : PlayerModel
    {
        
        public HumanPlayer()
        {
            
        }

       

        public override void PlayerMakesMove()
        {
            Console.WriteLine("Make your move: 'rock', 'paper', 'scissors', 'lizard', or 'spock'?");
        }
    }
}
