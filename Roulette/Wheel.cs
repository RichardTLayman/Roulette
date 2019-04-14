using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Wheel  
    {
        string[] rouletteWheel1 = { "0", "00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13",
                                    "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24",
                                    "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36"};

        string[] rouletteWheel2 = { "Green", "Green", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Black", "Red", "Black",
                                    "Red", "Black", "Red", "Black", "Red", "Red", "Black", "Red", "Black", "Red", "Black", "Red", "Black",
                                    "Red", "Black", "Red", "Black", "Black", "Red", "Black", "Red", "Black", "Red", "Black", "Red"};

        public int ball = 0;
        public string roul1;
        public string roul2;

        public int roul3;

        public int GetNumber()
        {
            Random rNum = new Random();
            int ball = rNum.Next(37);
            return ball;
        }

        public (int, string) GetRoll(int ball)
        {
            string stringRoul = rouletteWheel1[ball];
            roul2 = rouletteWheel2[ball];
            roul3 = 00;

            if (stringRoul == "00")
            {
                roul3 = 0;
            }
            else
            {
                roul3 = Convert.ToInt32(stringRoul);
            }

            Console.WriteLine($"The roullete ball landed on ({roul3}) ({roul2}).");
            
            return (roul3, roul2);
        }


    }
}
