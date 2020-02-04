using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11ATM
{
    class Input
    {
        public static bool AskUserContinue(string message, string yes, string no)
        {
            string input = "";
            while (input != yes && input != no)
            {
                input = GetUserInput(message).ToLower();
            }
            if (input == yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static double GetUserNumber(string message)
        {
            string input = "*";
            double number;

            while (!double.TryParse(input, out number))
            {
                input = GetUserInput(message);
            }

            return number;
        }
    }
}
