using System;

namespace EmployeeDirectory
{
    internal static class Util
    {
        internal static string AskForString(string prompt)
        {
            
            bool success = false;
            string answer;
            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        internal static double AskForDouble(string prompt)
        {
            bool success = false;
            double answer;
            do
            {
                string input = AskForString(prompt);

                success = double.TryParse(input, out answer);
                if (!success) Console.WriteLine("Wrong format");
                 
            } while (!success);

            return answer;
        }
    }
}