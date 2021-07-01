using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class LeapYear
    {
        public static void ReadInput()
        {
         
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            FindLeapYear(Year);
        }
        public static void FindLeapYear(int Year)
        {

            
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
            }

        }           
    }
}
