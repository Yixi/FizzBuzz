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

            return num.ToString();
        }
    }
}
