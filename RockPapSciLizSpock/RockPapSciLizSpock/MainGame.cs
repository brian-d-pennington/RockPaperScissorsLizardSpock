using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class MainGame
    {
        public PlayerModel playerOne;
        public PlayerModel playerTwo;
        public GameLogic gameLogic;
      

        public MainGame()
        {
            gameLogic = new GameLogic();
      
        }


        public void GameMenu()
        {
            gameLogic.DisplayRules();
            HowManyPlayers();
            playerOne.PlayerMakesMove();
            playerTwo.PlayerMakesMove()
            gameLogic.MatchOutcomes(playerOne, playerTwo);
        }

        public void HowManyPlayers()
        {
            Console.WriteLine("How many players will there be? enter 1 for one player, 2 for two players, and 0 to watch a computer match [fun!]");
            string playerChoice = Console.ReadLine();
            if (playerChoice == "1")
            {
                playerOne = new HumanPlayer();
                playerTwo = new ComputerPlayer();
                Console.WriteLine("Alright, you'll be playing the computer.");
            }
            else if (playerChoice == "2")
            {
                playerOne = new HumanPlayer();
                playerTwo = new HumanPlayer();
                Console.WriteLine("You will be playing another human.");
            }
            else if (playerChoice == "0")
            {
                playerOne = new ComputerPlayer();
                playerTwo = new ComputerPlayer();
                Console.WriteLine("You'll be watching a computerized match. Awesome use of your time.");
            }
            else
            {
                Console.WriteLine("Please enter one of the given options.");
                HowManyPlayers();
            }
        }
    }
}
