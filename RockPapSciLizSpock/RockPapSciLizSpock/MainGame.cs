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
        public GameLogic rules;
      

        public MainGame()
        {
            rules = new GameLogic();   
        }


        public void GameMenu()
        {
            rules.DisplayRules();

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
    }
}
