using System;
using ConsoleAppTasks.Infrastructure;

namespace ConsoleAppTasks.Tasks
{
    internal static class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Task 3 — HTTP Error Enum");

            int code = InputHelper.ReadInt("Enter HTTP error code (400-404):");

            if (Enum.IsDefined(typeof(HTTPError), code))
            {
                HTTPError error = (HTTPError)code;
                Console.WriteLine($"Error name: {error}");
            }
            else
            {
                Console.WriteLine("Unknown/unsupported HTTP error code for this enum.");
            }

            InputHelper.PrintSeparator();
        }

        private enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404
        }
    }
}