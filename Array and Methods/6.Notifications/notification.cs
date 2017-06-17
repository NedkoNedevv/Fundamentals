using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class notification
    {
        static void Main(string[] args)
        {

            int numberOfCommands = int.Parse(Console.ReadLine());

            while (numberOfCommands > 0)
            {
                string result = Console.ReadLine();
                string operation = Console.ReadLine();

                if (result == "success")
                {
                    string message = Console.ReadLine();
                    string successCommand = ShowSuccess(operation, message);
                    Console.WriteLine(successCommand);
                }
                else if (result == "error")
                {
                    int code = int.Parse(Console.ReadLine());
                    string errorCommand = ShowError(operation, code);
                    Console.WriteLine(errorCommand);
                }
                numberOfCommands--;
            }
        }

        private static string ShowError(string operation, int code)
        {
            if (code > 0)
            {
                string result = $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.";
                return result;
            }
            else
            {
                string result = $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.";
                return result;
            }
        }

        private static string ShowSuccess(string operation, string message)
        {
            string result = $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
            return result;
        }
    }
}
        
    

