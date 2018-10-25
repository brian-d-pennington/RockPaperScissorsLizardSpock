using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class MainGame
    {
        public GameLogic playerOne;
        public GameLogic playerTwo;
        public GameLogic rules;
      

        public MainGame()
        {
            playerOne = new GameLogic();
            playerTwo = new GameLogic();
            rules = new GameLogic();
            
        }


        public void GameMenu()
        {
            rules.DisplayRules();
            playerOne.PlayerOneSetup();
            playerTwo.PlayerTwoSetup();

        }
    }
}
