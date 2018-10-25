using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class GameLogic
    {

        
        



        public GameLogic()
        {

     
        }

        public void DisplayRules()
        {
            Console.WriteLine("Scissors cuts paper, paper covers rock, rock crushes lizard,");
            Console.WriteLine("lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard,");
            Console.WriteLine("lizard eats paper, paper disproves Spock, Spock vaporizes rock,");
            Console.WriteLine("and as it always has, rock crushes scissors.... good luck.");
            Console.WriteLine("----------------------------------------------------------");

        }

        public void HowManyPlayers()
        {
            Console.WriteLine("How many players will there be? enter 1 for one player, 2 for two players, and 0 to watch a computer match [fun!]");
            string playerChoice = Console.ReadLine();
            if (playerChoice == "1")
            {
                playerOne = new HumanPlayer();
                playerTwo = new ComputerPlayer();
            }
            else if (playerChoice == "2")
            {
                playerOne = new HumanPlayer();
                playerTwo = new HumanPlayer();
            }
            else if (playerChoice == "0")
            {
                playerOne = new ComputerPlayer();
                playerTwo = new ComputerPlayer();
            }
            else
            {
                Console.WriteLine("Please enter one of the given options.");
                HowManyPlayers();
            }
        }

        public void MatchOutcomes()
        {
            List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

            if ((playerOne == gestures[0] && playerTwo == gestures[2] || playerTwo == gestures[3]) || 
                (playerOne == gestures[2] && playerTwo == gestures[1] || playerTwo == gestures[3]) ||
                (playerOne == gestures[1] && playerTwo == gestures[0] || playerTwo == gestures[4]) ||
                (playerOne == gestures[3] && playerTwo == gestures[4] || playerTwo == gestures[1]) ||
                (playerOne == gestures[4] && playerTwo == gestures[2] || playerTwo == gestures[0]))
            {
                Console.WriteLine(playerOne + " wins this game.");
            }
            else if ((playerOne == gestures[0] && playerTwo == gestures[4] || playerTwo == gestures[1]) ||
                (playerOne == gestures[2] && playerTwo == gestures[4] || playerTwo == gestures[0]) ||
                (playerOne == gestures[1] && playerTwo == gestures[2] || playerTwo == gestures[3])||
                (playerOne == gestures[3] && playerTwo == gestures[0] || playerTwo == gestures[2]) ||
                (playerOne == gestures[4] && playerTwo == gestures[1] || playerTwo == gestures[3]))
            {
                Console.WriteLine(playerTwo + " wins this game.");
            }
            else
            {
                Console.WriteLine("Tie game. Neither player advances.");
            }
        }
    }
}
