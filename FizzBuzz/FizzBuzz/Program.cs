using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Let's play Fizz Buzz!" );

            //asks user for input
            Console.WriteLine("What number would you like to count to?");

            //variable stores user input
            int countTo = int.Parse(Console.ReadLine());

            //loops to number selected by user
            for (int i = 0; i <= countTo; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Creates fizzbuzz game. Automatically prints, fizz, buzz, or fizzbuzz
        /// Depending on conditional requiremets, 
        /// Divisible by 3, 5, or 3 and 5
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string FizzBuzz(int number)
        {
            //if both conditions are met
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz!";
            }
            //if either condition is met
            else if (number % 3 == 0 || number % 5 == 0)
            {
                //checks for divisibility between either 3 or 5
                if (number % 3 == 0)
                {
                    return "Fizz!";
                }
                else
                {
                    return "Buzz!";
                }
            }
            //if none of the conditions are met, returns number
            //converts number to string
            else
            {
                return number.ToString();
            }
        }
    }
}
