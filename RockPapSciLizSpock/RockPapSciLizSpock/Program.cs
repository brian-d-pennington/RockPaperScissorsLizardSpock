using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapSciLizSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMenu newGame = new GameMenu();

            newGame.GameMenu();

            Console.ReadLine();
        }
    }
}
