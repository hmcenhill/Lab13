using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public static class Validator
    {
        public static int GetInt(int min, int max)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
                {
                    return result;
                }
                Console.Write($"Please enter a value between {min} and {max}: ");
            }
        }
        public static bool KeepGoing(string question)
        {
            Console.Write($"{question} (y/n): ");
            while (true)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "y") return true;
                if (input == "n") return false;
                Console.Write("Please enter either y or n: ");

            }
        }
    }
}
