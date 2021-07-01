using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class LargestNumber
    {
        public static void ReadInput()
        {

            Console.WriteLine("Enter Three Numbers : ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = Convert.ToInt32(Console.ReadLine());
            int Number3 = Convert.ToInt32(Console.ReadLine());
            largestNumber(Number1, Number2, Number3);
        }
        // A function to find largest among three numbers

        public static void largestNumber(int A, int B, int C)
        {
            if (A >= B && A >= C)
                Console.WriteLine(A + " is the largest number.");

            if (B >= A && B >= C)
                Console.WriteLine(B + " is the largest number.");

            if (C >= A && C >= B)
                Console.WriteLine(C + " is the largest number.");


        }
    }
}
