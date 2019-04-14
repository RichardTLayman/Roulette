using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel();
            Bets bets = new Bets();                 

            wheel.ball = wheel.GetNumber();
            wheel.GetRoll(wheel.ball);

            Console.WriteLine();
            bets.TotalBets(wheel);

            Console.ReadKey();

        }
    }
}
