using System;

namespace Basicprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of basic programs");
            Console.WriteLine("Enter choice to select programs: ");
            Console.WriteLine("1.Flip Coin 2.Leap Year");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Flip Coin Program!");
                    FlipCoin.ReadInput();
                    break;
                case 2:
                    Console.WriteLine("Finding Leap Year Or Not!");
                    LeapYear.ReadInput();
                    break;

            }
          
        }
    }
}

