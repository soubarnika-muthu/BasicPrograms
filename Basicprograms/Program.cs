using System;

namespace Basicprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of basic programs");
            Console.WriteLine("Enter choice to select programs: ");
            Console.WriteLine("1.Flip Coin 2.Leap Year 3. Power Of Two");
            int choice = Convert.ToInt32(Console.ReadLine());
            //Selection statement
            switch(choice)
            {
                case 1:
                    //Computing Flip Coin Program
                    Console.WriteLine("Flip Coin Program!");
                    FlipCoin.ReadInput();
                    break;
                case 2:
                    ////Computing Leap Year Program
                    Console.WriteLine("Finding Leap Year Or Not!");
                    LeapYear.ReadInput();
                    break;
                case 3:
                    ////Computing Power Of Two Program
                    Console.WriteLine("Finding Power Of Two");
                    PowerOfTwo.ReadInput();
                    break;
            }
          
        }
    }
}

