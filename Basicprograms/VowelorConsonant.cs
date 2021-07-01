using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms
{
    class VowelorConsonant
    {
        //Reading input from the user
        public static void ReadInput()
        {
            Console.WriteLine("Enter Character: ");
            char c = Convert.ToChar(Console.ReadLine());
            vowelOrConsonant(c);
        }
        // A function to print wheather a character is vowel or consonant
       public static void vowelOrConsonant(char x)
        {
            if (x == 'a' || x == 'e' || x == 'i' ||
                              x == 'o' || x == 'u')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }
    }
}
