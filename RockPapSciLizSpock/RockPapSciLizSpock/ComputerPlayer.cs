using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    
    class ComputerPlayer : PlayerModel
    {
        string[] compGeneratedNames = new string[] { "Boris", "Gertrude", "Wally" , "Cece", "Martina" };

        public ComputerPlayer()
        {

        }

        public override void PlayerMakesMove()
        {
            throw new NotImplementedException();
        }

        public void computerGeneratedPlayerName()
        {
            
        }
    }   

}
