using System;

namespace hw03_IrynaMykhailevych
{
    enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404
    }
    internal class Task3
    {
        public static void Run()
        {
            int code = ReadInt("Enter HTTP error code: ");

            PrintErrorName(code);
        }
        static int ReadInt(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            int result;

            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Please enter the valid value: ");
                input = Console.ReadLine();
            }
            return result;
        }
        static void PrintErrorName(int code)
        {
            if (Enum.IsDefined(typeof(HTTPError), code))
            {
                HTTPError error = (HTTPError)code;
                Console.WriteLine($"The name of the HTTP error code {code} is: {error}");
            }
            else
            {
                Console.WriteLine($"The HTTP error code {code} is not defined.");
            }
        }
    }
}
