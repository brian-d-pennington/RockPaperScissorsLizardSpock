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

        public string playerChoice;
        public string humanPlayerNameOne;
        public string humanPlayerNameTwo;


        public MainGame()
        {
            gameLogic = new GameLogic();
      
        }


        public void GameMenu() //in the future, this GameMenu should be its own closs
        {
            gameLogic.DisplayRules();
            HowManyPlayers();
            if (playerChoice == "1")
            {
                PlayerOneEntersName();
            }
            else if (playerChoice == "2")
            {
                TwoPlayersEnterNames();
            }
            for (int i = 0; i < 5; i++)
            {
                playerOne.PlayerMakesMove();
                playerTwo.PlayerMakesMove();
                gameLogic.MatchOutcomes(playerOne, playerTwo);
                DisplayScores();
            }
            DisplayWinner();
            PlayAgainOrNot();
           
        }

        public void HowManyPlayers()
        {
            Console.WriteLine("How many players will there be? enter 1 for one player, 2 for two players, and 0 to watch a computer match [fun!]");
            playerChoice = Console.ReadLine();
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
        public void PlayerOneEntersName()
        {
            Console.WriteLine("Player one: please enter your name");
            humanPlayerNameOne = Console.ReadLine();
            Console.WriteLine("Player one: " + humanPlayerNameOne);
        }

        public void TwoPlayersEnterNames()
        {
            Console.WriteLine("Player one: please enter your name");
            humanPlayerNameOne = Console.ReadLine();
            Console.WriteLine("Player two: please enter your name as well");
            humanPlayerNameTwo = Console.ReadLine();
            Console.WriteLine("Player One: " + humanPlayerNameOne + " vs Player Two: " + humanPlayerNameTwo + ", let the game begin!");
        }
        
        public void DisplayScores()
        {
            Console.WriteLine("Player One: " + playerOne.score + ", Player Two:" + playerTwo.score);
        }

        public void DisplayWinner()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("Player One wins!");
            }
            else
            {
                Console.WriteLine("Player Two wins!");
            }
        }
        public void PlayAgainOrNot()
        {
            Console.WriteLine("Would you like to play or witness another match? Y/N");
            string yesNo = Console.ReadLine();
            if (yesNo == "Y")
            {
                GameMenu();
            }
            else if (yesNo == "N")
            {
                Console.WriteLine("ok byeeee");
            }
            else
            {
                Console.WriteLine("type correctly for once in your life..");
                PlayAgainOrNot();
            }
         
        }

    }   
}
