using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Bets
    {
        public void TotalBets(Wheel wheel)
        {
            // add all bets
            BetNumber(wheel);
            BetEvenOdd(wheel);
            BetRedBlack(wheel);
            BetLowHigh(wheel);
            BetDozens(wheel);
            BetColumns(wheel);
            BetStreet(wheel);
            BetSixNumbers(wheel);
            BetSplit(wheel);
            BetCorner(wheel);
        }

        void BetNumber(Wheel wheel)
        {
            if (wheel.roul1 == "null")
            {
                Console.WriteLine("The winning number was 00.");
            }
            else
            {
                Console.WriteLine($"The winning number was {wheel.roul3}.");
            }
        }

        void BetEvenOdd(Wheel wheel)
        {

            if (wheel.roul1 != "0" && wheel.roul1 != "00")
            {
                int bet = wheel.roul3;
                bet = bet % 2;

                if (bet == 0)
                {
                    Console.WriteLine("This bet was Even");
                }
                else
                {
                    Console.WriteLine("This bet was Odd");
                }
            }
            else
            {
                Console.WriteLine("This bet was not odd or even.");
            }            
        }

        void BetRedBlack(Wheel wheel)
        {
            if (wheel.roul2 == "Green")
            {
                Console.WriteLine("This bet was not red or black.");
            }
            else if (wheel.roul2 == "Red")
            {
                Console.WriteLine("This bet was Red.");
            }
            else 
            {
                Console.WriteLine("This bet was Black.");
            }
        }

        // low (1-18) high (19-36)
        void BetLowHigh(Wheel wheel)
        {

            if (wheel.roul3 == 0)
            {
                Console.WriteLine("This bet was not high or low.");
            }
            else if (wheel.roul3 >= 1 && wheel.roul3 <= 18)
            {
                Console.WriteLine("This bet was Low.");
            }
            else
            {
                Console.WriteLine("This bet was High");
            }
        }

        //row thirds, 1-12, 13-24, 25-36
        void BetDozens(Wheel wheel)
        {
            if(wheel.roul3 == 0)
            {
                Console.WriteLine("This bet was not a dozen.");
            }
            else if (wheel.roul3 >= 1 && wheel.roul3 <= 12)
            {
                Console.WriteLine("This bet was in the First Dozen.");
            }
            else if (wheel.roul3 >= 13 && wheel.roul3 <= 24)
            {
                Console.WriteLine("This bet was in the Second Dozen.");
            }
            else 
            {
                Console.WriteLine("This bet was in the Third Dozen.");
            }
        }

        void BetColumns(Wheel wheel)
        {
            int number = wheel.roul3;
            number = number % 3;

            if (wheel.roul3 == 0)
            {
                Console.WriteLine("This bet was not a column.");
            }
            else if (number == 1)
            {
                Console.WriteLine("This bet was in the First Column.");
            }
            else if (number == 2)
            {
                Console.WriteLine("This bet was in the Second Column.");
            }
            else 
            {
                Console.WriteLine("This bet was in the Third Column.");
            }
        }

        // Streets are the rows, 1-3, 2-6, etc
        void BetStreet(Wheel wheel)
        {
            if (wheel.roul3 == 0)
            {
                Console.WriteLine("This bet was not a street.");
            }
            else if (wheel.roul3 >= 1 && wheel.roul3 <= 3)
            {
                Console.WriteLine("This bet was in Street One.");
            }
            else if (wheel.roul3 >= 4 && wheel.roul3 <= 6)
            {
                Console.WriteLine("This bet was in Street Two.");
            }
            else if (wheel.roul3 >= 7 && wheel.roul3 <= 9)
            {
                Console.WriteLine("This bet was in Street Three.");
            }
            else if (wheel.roul3 >= 10 && wheel.roul3 <= 12)
            {
                Console.WriteLine("This bet was in Street Four.");
            }
            else if (wheel.roul3 >= 13 && wheel.roul3 <=15)
            {
                Console.WriteLine("This bet was in Street Five.");
            }
            else if (wheel.roul3 >= 16 && wheel.roul3 <= 18)
            {
                Console.WriteLine("This bet was in Street Six.");
            }
            else if (wheel.roul3 >= 19 && wheel.roul3 <= 21)
            {
                Console.WriteLine("This bet was in Street Seven.");
            }
            else if (wheel.roul3 >= 22 && wheel.roul3 <= 24)
            {
                Console.WriteLine("This bet was in Street Eight.");
            }
            else if (wheel.roul3 >= 25 && wheel.roul3 <= 27)
            {
                Console.WriteLine("This bet was in Street Nine.");
            }
            else if (wheel.roul3 >= 28 && wheel.roul3 <= 30)
            {
                Console.WriteLine("This bet was in Street Ten.");
            }
            else if (wheel.roul3 >= 31 && wheel.roul3 <= 33)
            {
                Console.WriteLine("This bet was in Street Eleven.");
            }
            else if (wheel.roul3 >= 34 && wheel.roul3 <= 36)
            {
                Console.WriteLine("This bet was in Street Twelve.");
            }
        }

        void BetSixNumbers(Wheel wheel)
        {
            if (wheel.roul3 == 0)
            {
                Console.WriteLine("This bet was not a six numbers.");
            }
            else if (wheel.roul3 >= 1 && wheel.roul3 <= 3)
            {
                Console.WriteLine("This bet of six covers 1, 2, 3, 4, 5, and 6.");
            }
            else if (wheel.roul3 >= 4 && wheel.roul3 <= 6)
            {
                Console.WriteLine("This bet of six covers 1, 2, 3, 4, 5, and 6 as well as 4, 5, 6, 7, 8 and 9.");
            }
            else if (wheel.roul3 >= 7 && wheel.roul3 <= 9)
            {
                Console.WriteLine("This bet of six covers 4, 5, 6, 7, 8 and 9 as well as 7, 8, 9, 10, 11, and 12.");
            }
            else if (wheel.roul3 >= 10 && wheel.roul3 <= 12)
            {
                Console.WriteLine("This bet of six covers 7, 8, 9, 10, 11, and 12 as well as 10, 11, 12, 13, 14, and 15.");
            }
            else if (wheel.roul3 >= 13 && wheel.roul3 <= 15)
            {
                Console.WriteLine("This bet of six covers 10, 11, 12, 13, 14, and 15 as well as 13, 14, 15, 16, 17, and 18.");
            }
            else if (wheel.roul3 >= 16 && wheel.roul3 <= 18)
            {
                Console.WriteLine("This bet of six covers 13, 14, 15, 16, 17, and 18 as well as 16, 17, 18, 19, 20, and 21.");
            }
            else if (wheel.roul3 >= 19 && wheel.roul3 <= 21)
            {
                Console.WriteLine("This bet of six covers 16, 17, 18, 19, 20, and 21 as well as 19, 20, 21, 22, 23, and 24.");
            }
            else if (wheel.roul3 >= 22 && wheel.roul3 <= 24)
            {
                Console.WriteLine("This bet of six covers 19, 20, 21, 22, 23, and 24 as well as 22, 23, 24, 25, 26, and 27.");
            }
            else if (wheel.roul3 >= 25 && wheel.roul3 <= 27)
            {
                Console.WriteLine("This bet of six covers 22, 23, 24, 25, 26, and 27 as well as 25, 26, 27, 28, 29, and 30.");
            }
            else if (wheel.roul3 >= 28 && wheel.roul3 <= 30)
            {
                Console.WriteLine("This bet of six covers 25, 26, 27, 28, 29, and 30 as well as 28, 29, 30, 31, 32, and 33.");
            }
            else if (wheel.roul3 >= 31 && wheel.roul3 <= 33)
            {
                Console.WriteLine("This bet of six covers 28, 29, 30, 31, 32, and 33 as well as 31, 32, 33, 34, 35 and 36.");
            }
            else 
            {
                Console.WriteLine("This bet of six covers 31, 32, 33, 34, 35 and 36.");
            }
        }

        void BetSplit(Wheel wheel)
        {
            if (wheel.roul3 == 0)
            {
                Console.WriteLine("This bet split 0 and 00.");
            }
            else if (wheel.roul3 == 1)
            {
                Console.WriteLine("This bet splits between 1/2 and 1/4.");
            }
            else if (wheel.roul3 == 2)
            {
                Console.WriteLine("This bet splits between 2/1, 2/3, and 2/5.");
            }
            else if (wheel.roul3 == 3)
            {
                Console.WriteLine("This bet splits between 3/2 and 3/6.");
            }
            else if (wheel.roul3 == 4)
            {
                Console.WriteLine("This bet splits between 4/1, 4/5, and 4/7.");
            }
            else if (wheel.roul3 == 5)
            {
                Console.WriteLine("This bet splits between 5/2, 5/4, 5/6, and 5/8.");
            }
            else if (wheel.roul3 == 6)
            {
                Console.WriteLine("This bet splits between 6/3, 6/5, and 6/9.");
            }
            else if (wheel.roul3 == 7)
            {
                Console.WriteLine("This bet splits between 7/4, 7/8, and 7/10.");
            }
            else if (wheel.roul3 == 8)
            {
                Console.WriteLine("This bet splits between 8/5, 8/7, 8/9, and 8/11.");
            }
            else if (wheel.roul3 == 9)
            {
                Console.WriteLine("This bet splits between 9/6, 9/8, and 9/12.");
            }
            else if (wheel.roul3 == 10)
            {
                Console.WriteLine("This bet splits between 10/7, 10/11, and 10/13.");
            }
            else if (wheel.roul3 == 11)
            {
                Console.WriteLine("This bet splits between 11/8, 11/10, 11/12, and 11/14.");
            }
            else if (wheel.roul3 == 12)
            {
                Console.WriteLine("This bet splits between 12/9, 12/11, 12/15.");
            }
            else if (wheel.roul3 == 13)
            {
                Console.WriteLine("This bet splits between 13/10, 13/14, and 13/16.");
            }
            else if (wheel.roul3 == 14)
            {
                Console.WriteLine("This bet splits between 14/11, 14/13, 14/15, and 14/17.");
            }
            else if (wheel.roul3 == 15)
            {
                Console.WriteLine("This bet splits between 15/12, 15/14, and 15/18.");
            }
            else if (wheel.roul3 == 16)
            {
                Console.WriteLine("This bet splits between 16/13, 16/17, and 16/19.");
            }
            else if (wheel.roul3 == 17)
            {
                Console.WriteLine("This bet splits between 17/14, 17/16, 17/18, and 17/20.");
            }
            else if (wheel.roul3 == 18)
            {
                Console.WriteLine("This bet splits between 18/15, 18/17, and 18/21.");
            }
            else if (wheel.roul3 == 19)
            {
                Console.WriteLine("This bet splits between 19/16, 19/20, and 19/22.");
            }
            else if (wheel.roul3 == 20)
            {
                Console.WriteLine("This bet splits between 20/17, 20/19, 20/21, and 20/23.");
            }
            else if (wheel.roul3 == 21)
            {
                Console.WriteLine("This bet splits between 21/18, 21/20, and 21/24.");
            }
            else if (wheel.roul3 == 22)
            {
                Console.WriteLine("This bet splits between 22/19, 22/23, and 22/25.");
            }
            else if (wheel.roul3 == 23)
            {
                Console.WriteLine("This bet splits between 23/20, 23/22, 23/24, and 23/26.");
            }
            else if (wheel.roul3 == 24)
            {
                Console.WriteLine("This bet splits between 24/21, 24/23, and 24/27.");
            }
            else if (wheel.roul3 == 25)
            {
                Console.WriteLine("This bet splits between 25/22, 25/26, and 25/28.");
            }
            else if (wheel.roul3 == 26)
            {
                Console.WriteLine("This bet splits between 26/23, 26/25, 26/27, and 26/29.");
            }
            else if (wheel.roul3 == 27)
            {
                Console.WriteLine("This bet splits between 27/24, 27/26, and 27/30.");
            }
            else if (wheel.roul3 == 28)
            {
                Console.WriteLine("This bet splits between 28/25, 28/29, and 28/31.");
            }
            else if (wheel.roul3 == 29)
            {
                Console.WriteLine("This bet splits between 29/26, 29/28, 29/30, and 29/32.");
            }
            else if (wheel.roul3 == 30)
            {
                Console.WriteLine("This bet splits between 30/27, 30/29, and 30/33.");
            }
            else if (wheel.roul3 == 31)
            {
                Console.WriteLine("This bet splits between 31/28, 31/32, and 31/34.");
            }
            else if (wheel.roul3 == 32)
            {
                Console.WriteLine("This bet splits between 32/29, 32/31, 32/33, and 32/35.");
            }
            else if (wheel.roul3 == 33)
            {
                Console.WriteLine("This bet splits between 33/30, 33/32, and 33/36.");
            }
            else if (wheel.roul3 == 34)
            {
                Console.WriteLine("This bet splits between 34/31 and 34/35.");
            }
            else if (wheel.roul3 == 35)
            {
                Console.WriteLine("This bet splits between 35/32, 35/34, and 35/36.");
            }
            else 
            {
                Console.WriteLine("This bet splits between 36/33 and 36/35.");
            }
        }

        void BetCorner(Wheel wheel)
        {
            if (wheel.roul3 == 0)
            {
                Console.WriteLine("This bet has no corners.");
            }
            else if (wheel.roul3 == 1)
            {
                Console.WriteLine("This bet corners between 1/2/4/5.");
            }
            else if (wheel.roul3 == 2)
            {
                Console.WriteLine("This bet corners between 1/2/4/5 and 2/3/5/6.");
            }
            else if (wheel.roul3 == 3)
            {
                Console.WriteLine("This bet corners between 2/3/5/6.");
            }
            else if (wheel.roul3 == 4)
            {
                Console.WriteLine("This bet corners between 1/2/4/5 and 4/5/7/8.");
            }
            else if (wheel.roul3 == 5)
            {
                Console.WriteLine("This bet corners between 1/2/4/5/, 2/3/5/6, 4/5/7/8 and 5/6/8/9.");
            }
            else if (wheel.roul3 == 6)
            {
                Console.WriteLine("This bet corners between 2/3/5/6 and 5/6/8/9.");
            }
            else if (wheel.roul3 == 7)
            {
                Console.WriteLine("This bet corners between 4/5/7/8 and 7/8/10/11.");
            }
            else if (wheel.roul3 == 8)
            {
                Console.WriteLine("This bet corners between 4/5/7/8, 5/6/8/9, 7/8/10/11, and 8/9/11/12.");
            }
            else if (wheel.roul3 == 9)
            {
                Console.WriteLine("This bet corners between 5/6/8/9 and 8/9/11/12.");
            }
            else if (wheel.roul3 == 10)
            {
                Console.WriteLine("This bet corners between 7/8/10/11 and 10/11/13/14.");
            }
            else if (wheel.roul3 == 11)
            {
                Console.WriteLine("This bet corners between 7/8/10/11, 8/9/11/12, 10/11/13/14 and 11/12/14/15.");
            }
            else if (wheel.roul3 == 12)
            {
                Console.WriteLine("This bet corners between 8/9/11/12 and 11/12/14/15.");
            }
            else if (wheel.roul3 == 13)
            {
                Console.WriteLine("This bet corners between 10/11/13/14 and 13/14/16/17.");
            }
            else if (wheel.roul3 == 14)
            {
                Console.WriteLine("This bet corners between 10/11/13/14, 11/12/14/15, 13/14/16/17 and 14/15/17/18.");
            }
            else if (wheel.roul3 == 15)
            {
                Console.WriteLine("This bet corners between 11/12/14/15 ad 14/15/17/18.");
            }
            else if (wheel.roul3 == 16)
            {
                Console.WriteLine("This bet corners between 13/14/16/17 and 16/17/19/20.");
            }
            else if (wheel.roul3 == 17)
            {
                Console.WriteLine("This bet corners between 13/14/16/17, 14/15/17/18, 16/17/19/20 and 17/18/20/21.");
            }
            else if (wheel.roul3 == 18)
            {
                Console.WriteLine("This bet corners between 14/15/17/18 and 17/18/20/21.");
            }
            else if (wheel.roul3 == 19)
            {
                Console.WriteLine("This bet corners between 16/17/19/20 and 19/20/22/23.");
            }
            else if (wheel.roul3 == 20)
            {
                Console.WriteLine("This bet corners between 16/17/19/20, 17/18/20/21, 19/20/22/23 and 20/21/23/24.");
            }
            else if (wheel.roul3 == 21)
            {
                Console.WriteLine("This bet corners between 17/18/20/11 and 20/21/23/24.");
            }
            else if (wheel.roul3 == 22)
            {
                Console.WriteLine("This bet corners between 19/20/22/23 and 22/23/25/26.");
            }
            else if (wheel.roul3 == 23)
            {
                Console.WriteLine("This bet corners between 19/20/22/23, 20/21/23/24, 22/23/25/26 and 23/24/26/27.");
            }
            else if (wheel.roul3 == 24)
            {
                Console.WriteLine("This bet 20/21/23/24 and 23/24/26/27.");
            }
            else if (wheel.roul3 == 25)
            {
                Console.WriteLine("This bet corners between 22/23/25/26 and 25/26/28/29.");
            }
            else if (wheel.roul3 == 26)
            {
                Console.WriteLine("This bet corners between 22/23/25/26, 23/24/26/27, 25/26/28/29 and 26/27/29/30.");
            }
            else if (wheel.roul3 == 27)
            {
                Console.WriteLine("This bet corners between 23/24/26/27 and 26/27/29/30.");
            }
            else if (wheel.roul3 == 28)
            {
                Console.WriteLine("This bet corners between 25/26/28/29 and 28/29/31/32.");
            }
            else if (wheel.roul3 == 29)
            {
                Console.WriteLine("This bet corners between 25/26/28/29, 26/27/29/30, 28/29/31/32 and 29/30/32/33.");
            }
            else if (wheel.roul3 == 30)
            {
                Console.WriteLine("This bet corners between 26/27/29/30 and 29/30/32/33.");
            }
            else if (wheel.roul3 == 31)
            {
                Console.WriteLine("This bet corners between 28/29/31/32 and 31/32/34/35.");
            }
            else if (wheel.roul3 == 32)
            {
                Console.WriteLine("This bet 28/29/31/32, 29/30/32/33, 31/32/34/35 and 32/33/35/36.");
            }
            else if (wheel.roul3 == 33)
            {
                Console.WriteLine("This bet corners between 29/30/32/33 and 32/33/35/36.");
            }
            else if (wheel.roul3 == 34)
            {
                Console.WriteLine("This bet corners between 31/32/34/35.");
            }
            else if (wheel.roul3 == 35)
            {
                Console.WriteLine("This bet corners between 31/32/34/35 and 32/33/35/36.");
            }
            else
            {
                Console.WriteLine("This bet corners between 32/33/35/36.");
            }
        }
    }
}

//int[] columnOne = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
//int[] columnTwo = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
//int[] columnThree = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
