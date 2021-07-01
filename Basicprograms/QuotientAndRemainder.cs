using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class QuotientAnd_Remainder
    {
        
            //Reading input from the user
            public static void ReadInput()
            {

                Console.WriteLine("Enter Dividend And Divisor : ");
                int dividend = Convert.ToInt32(Console.ReadLine());
                int divisor = Convert.ToInt32(Console.ReadLine());
                FindQuotientAndRemainder(dividend, divisor);

            }
            // A function to find quotient and remainder
            
            public static void FindQuotientAndRemainder(int dividend, int divisor)
            {
                //Computing quotient and remainder using division and modulo operators
                int quotient = dividend / divisor;
                int remainder = dividend % divisor;

                Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
                Console.ReadLine();
            }
        }
    }

