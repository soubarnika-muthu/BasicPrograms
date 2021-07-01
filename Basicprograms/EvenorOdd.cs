using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class EvenorOdd
    {
        public static void ReadInput()
        {

            Console.WriteLine("Enter  Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            FindEvenorOdd(Number);
        }
        // A function to find even or odd two numbers

        public static void FindEvenorOdd(int num)
        {
           
                if (num % 2 == 0)
                {
                    Console.WriteLine(num+ "Even number");
                }
                else
                {
                    Console.WriteLine(num+ "odd number:");
                }
           
        }

    }
}
