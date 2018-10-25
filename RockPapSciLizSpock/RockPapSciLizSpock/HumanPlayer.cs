using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class HumanPlayer : PlayerModel
    {
        public string humanPlayerOneName;
        public string humanPlayerTwoName;
        public HumanPlayer()
        {

        }

        public void getHumanPlayerName()
        {
            Console.WriteLine("Please enter your name:");
            playerName = Console.ReadLine();
        }

        public override void PlayerMakesMove()
        {
            throw new NotImplementedException();
        }
    }
}
