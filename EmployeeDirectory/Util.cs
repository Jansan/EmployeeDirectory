using System;

namespace EmployeeDirectory
{
    //Static class cant make instances of. exactly as the Console class for example
    internal static class Util
    {
        //must be static in a static class
        //string return type
        //AskForString method name
        internal static string AskForString(string prompt)
        {
            
            bool success = false;
            string answer;//Scope
            do//Repeat
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                //If answer is not null or empty string
                if (!string.IsNullOrEmpty(answer))
                {
                    //Set bool success to true to exit loop
                    success = true;
                }

            } while (!success);//until we have get a correct value

            return answer;//return value
        }

        internal static double AskForDouble(string prompt)
        {
            bool success = false;
            double answer;
            do//Repeat
            {
                //Try to parse string to int returns bool
                //If true exit loop
                string input = AskForString(prompt);

                success = double.TryParse(input, out answer);
                if (!success) Console.WriteLine("Wrong format");//Write error message
                 
            } while (!success);

            //Returns parsed string
            return answer;
        }
    }
}