using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class GameLogic
    {
        public string playerOne;
        public string playerTwo;
        
        // all possible player scenarios

        public string humanPlayerOneName;
        public string humanPlayerTwoName;

        public string computerPlayerOne;
        public string computerPlayerTwo;

        
       



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

        public void PlayerOneSetup()
        {
            Console.WriteLine("Is player one a human or computer? (human / computer)");
            string responseOne = Console.ReadLine();
            if (responseOne == "human")
            {
                Console.WriteLine("Please enter your name then.");
                humanPlayerOneName = Console.ReadLine();
                Console.WriteLine("Thanks, " + humanPlayerOneName);
                playerOne = humanPlayerOneName;
            }
            else if (responseOne == "computer")
            {
                Console.WriteLine("ok, player one is computer generated");
                computerPlayerOne = "Computer One";
                playerOne = computerPlayerOne;
            }
            else
            {
                Console.WriteLine("invalid entry.");
                PlayerOneSetup();
            }
        }
        public void PlayerTwoSetup() { 
            Console.WriteLine("Is player two a human or computer? (human / computer)");
            string responseTwo = Console.ReadLine();
            if (responseTwo == "human")
            {
                Console.WriteLine("Please enter your name then.");
                humanPlayerTwoName = Console.ReadLine();
                Console.WriteLine("Thanks, " + humanPlayerTwoName);
                playerTwo = humanPlayerTwoName;
            }
            else if (responseTwo == "computer")
            {
                Console.WriteLine("ok, player two is computer generated");
                computerPlayerTwo = "Computer Two";
                playerTwo = computerPlayerTwo;
            }
            else
            {
                Console.WriteLine("invalid entry. haha now you have to start over");
                PlayerTwoSetup();
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
