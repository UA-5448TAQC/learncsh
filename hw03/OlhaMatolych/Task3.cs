
namespace ConsoleApp1
{
    internal class Program
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

            Console.WriteLine("Please enter HTTP error code:");

            int code;
            while (!int.TryParse(Console.ReadLine(), out code))

            {
                Console.WriteLine("Invalid input. Enter a valid int number:");
            }

            if (Enum.IsDefined(typeof(HTTPError), code))
            {
                HTTPError error = (HTTPError)code;
                Console.WriteLine("Error name: " + error);
            }
            else
            {
                Console.WriteLine("Unknown HTTP error code.");
            }
        }
    }
}
   
