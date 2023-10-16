using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (num % 3 == 0)
            {
                return "Fizz";
            }

            if (num % 5 == 0)
            {
                return "Buzz";
            }

            if (num % 7 == 0)
            {
                return "Whizz";
            }

            return num.ToString();
        }
    }
}
