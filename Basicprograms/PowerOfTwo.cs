using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class PowerOfTwo
    {
       
            public static void ReadInput()
            {

                Console.WriteLine("Enter Power : ");
                int Power = Convert.ToInt32(Console.ReadLine());
                FindPowerOfTwo(Power);
            }
        public static void FindPowerOfTwo(int num)
        {
            
            for(int i=0;i<=num;i++)
            {
                Console.WriteLine(Math.Pow(2,i)+" ");
            }

        }
     }
}
