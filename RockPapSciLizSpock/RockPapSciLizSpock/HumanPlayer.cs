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
            string move = Console.ReadLine();
            if (move == "rock")
            {
                makesMove = "rock";
            }
            else if (move == "paper")
            {
                makesMove = "paper";
            }
            else if (move == "scissors")
            {
                makesMove = "scissors";
            }
            else if (move == "lizard")
            {
                makesMove = "lizard";
            }
            else if (move == "spock")
            {
                makesMove = "spock";
            }
            else
            {
                Console.WriteLine("please type more carefully");
                PlayerMakesMove();
            }
        }
    }
}
