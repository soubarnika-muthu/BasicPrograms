using System;

namespace Basicprograms
{
    // 1.Flip coin program
    // 2.Leap Year Program
    // 3.Power Of Two Program
    // 4.Harmonic Number Program
    // 5.Prime Factors program
    // 6.Quotient And Reaminder Program
    // 7.Swapping of Two Numbers
    //8.Even or Odd
    //9.Vowel or Consonant
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of basic programs");
            Console.WriteLine("Enter choice to select programs: ");
            Console.WriteLine("1.Flip Coin 2.Leap Year 3. Power Of Two 4.Harmonic Number 5.Prime Factors 6.Quotient And Reaminder ");
            Console.WriteLine("7.Swapping of two numbers 8.Even or Odd 9.Vowel or Consonant 10.Largest Number");
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
                case 4:
                    ////Computing Harmonic Number Program
                    Console.WriteLine("Finding Nth Harmonic Number!");
                    HarmonicNumber.ReadInput();
                    break;
                case 5:
                    ////Computing Prime Factor Program
                    Console.WriteLine("Finding Prime Factors!");
                    PrimeFactors.ReadInput();
                    break;
                case 6:
                    //Computing Quotient And Reaminder  Program
                    Console.WriteLine("Finding Quotient And Reaminder!");
                    QuotientAnd_Remainder.ReadInput();
                    break;
                case 7:
                    
                    Console.WriteLine("Swapping of Two Numbers!");
                    SwapTwoNumbers.ReadInput();
                    break;
                case 8:
                    Console.WriteLine("Finding Even Or Odd!");
                    EvenorOdd.ReadInput();
                    break;
                case 9:
                    Console.WriteLine("Finding Vowel or Consonant");
                    VowelorConsonant.ReadInput();
                    break;
                case 10:
                    Console.WriteLine("Finding Largest Number ");
                    LargestNumber.ReadInput();
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice!!!");
                    break;
            }
          
        }
    }
}

