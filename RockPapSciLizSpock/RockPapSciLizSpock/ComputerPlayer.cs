using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    
    class ComputerPlayer : PlayerModel
    {
     

        public ComputerPlayer()
        {

        }

        public override void PlayerMakesMove()
        {
            Random r = new Random();
            // ... Get three random numbers.
            //     Always 5, 6, 7, 8 or 9.
            Console.WriteLine(r.Next(5, 10));
        }

        public void computerGeneratedPlayerName()
        {
            
        }
    }   

}
