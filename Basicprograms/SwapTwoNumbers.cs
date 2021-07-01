using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class SwapTwoNumbers
    {
        //Reading input from the user
        public static void ReadInput()
        {

            Console.WriteLine("Enter Two Numbers : ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Swap(Number1, Number2);
        }
        // A function to Swap two numbers

        public static void Swap(int num1, int num2)
        {
            int temp = 0;//Temporary variable
            Console.Write("\nBefore Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
        }
    }
}
