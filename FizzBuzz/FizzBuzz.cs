using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }

            if (num % 5 == 0)
            {
                return "Buzz";
            }

            return num.ToString();
        }
    }
}
