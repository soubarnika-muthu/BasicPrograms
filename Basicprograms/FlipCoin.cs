using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class FlipCoin
    {
        //Flip Coin and print percentage of Heads and Tails
        //Reading input from user
        public static void ReadInput()
        {
            Console.WriteLine("ENTER NUMBER OF TIMES O FLIP A COIN");
            int numoftimes = Convert.ToInt32(Console.ReadLine());
            FindPercentage(numoftimes);
        }
        //Using method Findpercentage to find percentage of tail and head
        private static void FindPercentage(int num)
        {
            int tail = 0, head = 0;
            //Creating an object or instance for random class
            Random random = new Random();
            //Using for loop to flip coin for given number of times
            for (int i = 0; i < num; i++)
            {
                //Using Random Function to get value between 0 and 1.
                double randomvalue = random.NextDouble();
                //Checking condition to find head or tail
                if (randomvalue < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            //calculating percentage of Tail and Head Using formula
            double tailpercentage = (double)tail / num * 100;
            double headpercentage = (double)head / num * 100;
            Console.WriteLine("Number of tails is " + tail + " out of " + num);
            Console.WriteLine("Percentage of Tail is " + tailpercentage);
            Console.WriteLine("Number of Heads is " + head + " out of " + num);
            Console.WriteLine("Percentage of Head is " + headpercentage);


        }

    }
}