using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class HarmonicNumber
    {
        //Reading input from the user
        public static void ReadInput()
        {

            Console.WriteLine("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindNthHarmonicNumber(num);
        }
        //Using method to findnth harmonic number
        public static void FindNthHarmonicNumber(int n)
        {
            double sum = 0;
            //computing nth harmonic number using formula
            for (int i = 1; i <= n; i++)
            {
                sum = sum +(double) 1 / i;
            }
            Console.WriteLine(n+"th Harmonic Number :" +sum);
        }
    }
}
