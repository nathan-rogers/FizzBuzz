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
            int countTo = 0;

            Console.WriteLine("Let's play Fizz Buzz!" );
            Console.WriteLine("What number would you like to count to?");
            countTo = int.Parse(Console.ReadLine());
            for (int i = 0; i <= countTo; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.ReadKey();
        }
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz!";
            }
            else if (number % 3 == 0 || number % 5 == 0)
            {
                if (number % 3 == 0)
                {
                    return "Fizz!";
                }
                else
                {
                    return "Buzz!";
                }
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
