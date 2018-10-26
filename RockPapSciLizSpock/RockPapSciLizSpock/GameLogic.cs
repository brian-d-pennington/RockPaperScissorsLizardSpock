using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class GameLogic
    {
        List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        public GameLogic()
        {

     
        }

        public void DisplayRules()
        {
            Console.WriteLine("----ROCK----PAPER----SCISSORS----LIZARD----SPOCK----");
            Console.WriteLine("Scissors cuts paper, paper covers rock, rock crushes lizard,");
            Console.WriteLine("lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard,");
            Console.WriteLine("lizard eats paper, paper disproves Spock, Spock vaporizes rock,");
            Console.WriteLine("and as it always has, rock crushes scissors.... good luck.");
            Console.WriteLine("----------------------------------------------------------");

        }


        

        public void MatchOutcomes(PlayerModel playerOne, PlayerModel playerTwo)
        { 

            if ((playerOne.makesMove == gestures[0] && playerTwo.makesMove == gestures[2] || playerTwo.makesMove == gestures[3]) || 
                (playerOne.makesMove == gestures[2] && playerTwo.makesMove == gestures[1] || playerTwo.makesMove == gestures[3]) ||
                (playerOne.makesMove == gestures[1] && playerTwo.makesMove == gestures[0] || playerTwo.makesMove == gestures[4]) ||
                (playerOne.makesMove == gestures[3] && playerTwo.makesMove == gestures[4] || playerTwo.makesMove == gestures[1]) ||
                (playerOne.makesMove == gestures[4] && playerTwo.makesMove == gestures[2] || playerTwo.makesMove == gestures[0]))
            {
                Console.WriteLine("Player One wins this game.");
                playerOne.score++;

            }
            else if ((playerOne.makesMove == gestures[0] && playerTwo.makesMove == gestures[4] || playerTwo.makesMove == gestures[1]) ||
                (playerOne.makesMove == gestures[2] && playerTwo.makesMove == gestures[4] || playerTwo.makesMove == gestures[0]) ||
                (playerOne.makesMove == gestures[1] && playerTwo.makesMove == gestures[2] || playerTwo.makesMove == gestures[3])||
                (playerOne.makesMove == gestures[3] && playerTwo.makesMove == gestures[0] || playerTwo.makesMove == gestures[2]) ||
                (playerOne.makesMove == gestures[4] && playerTwo.makesMove == gestures[1] || playerTwo.makesMove == gestures[3]))
            {
                Console.WriteLine("Player Two wins this game.");
                playerTwo.score++;
            }
            else
            {
                Console.WriteLine("Tie game. Neither player advances.");
            }
        }
    }
}
