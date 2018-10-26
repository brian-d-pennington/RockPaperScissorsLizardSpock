using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    
    class ComputerPlayer : PlayerModel
    {
     

        public ComputerPlayer()
        {

        }

        public override void PlayerMakesMove()
        {
            Console.WriteLine("Computer chooses rock, paper, scissors, lizard, or spock..");
            System.Threading.Thread.Sleep(3000); // to give it a more human-like response

            Random r = new Random();
            int x = r.Next(5, 10);
            if (x == 5)
            {
                makesMove = "rock";
            }
            else if (x == 6)
            {
                makesMove = "paper";
            }
            else if (x == 7)
            {
                makesMove = "scissors";
            }
            else if (x == 8)
            {
                makesMove = "lizard";
            }
            else
            {
                makesMove = "spock";
            }
            Console.WriteLine("Computer chooses " + makesMove);
        }

        public void computerGeneratedPlayerName()
        {
            
        }
    }   

}
