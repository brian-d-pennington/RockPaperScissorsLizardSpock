﻿using System;
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
        public string humanPlayerNameOne = "no name currently";
        public string humanPlayerNameTwo = "also no name currently";


        public MainGame()
        {
            gameLogic = new GameLogic();
      
        }


        public void GameMenu()
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
            //future game loop
            playerOne.PlayerMakesMove();
            playerTwo.PlayerMakesMove();
            gameLogic.MatchOutcomes(playerOne, playerTwo);
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
          
    }   
}
