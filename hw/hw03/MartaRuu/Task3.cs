using System.Transactions;

namespace ConsoleApp3
{

    enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500,
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 3");
            Console.WriteLine("Enter HTTP error code (e.g., 400, 401, 403, 404, 500): ");
            int errorCode = int.Parse(Console.ReadLine());
            if (Enum.IsDefined(typeof(HTTPError), errorCode))
            {
                HTTPError err = (HTTPError)errorCode;
                Console.WriteLine($"HTTP error {err}");
            }
            else
            {
                Console.WriteLine("Unknown error");
            }

        }
    }
}
