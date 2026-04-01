namespace ConsoleApp1
{
    internal class Task_3
    {
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Yo enter your HTTP error code:");
            int errorCode = ReadInt();

            if (Enum.IsDefined(typeof(HTTPError), errorCode))
            {
                HTTPError error = (HTTPError)errorCode;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {error}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, but this code is not yet known.");
                Console.ResetColor();
            }

            int ReadInt()
            {
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please try again.");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
