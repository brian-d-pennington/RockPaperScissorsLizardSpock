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

       

        public override string PlayerMakesMove()
        {
            Console.WriteLine("Make your move: 'rock', 'paper', 'scissors', 'lizard', or 'spock'?");
            string move = Console.ReadLine();
            if (move == "rock")
            {
                return gestures[0];
            }
            else if (move == "paper")
            {
                return 
            }
            else if (move == "scissors")
            {
                return
            }
            else if (move == "lizard")
            {
                return
            }
            else if (move == "spock")
            {
                return
            }
            else
            {
                Console.WriteLine("please type more carefully");
                PlayerMakesMove();
            }
        }
    }
}
