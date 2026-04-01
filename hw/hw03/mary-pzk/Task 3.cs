namespace HW_3
{
    enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404
    }
    internal class Task_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a code:");
            int.TryParse(Console.ReadLine(), out int code);
            if (Enum.IsDefined(typeof(HTTPError), code))
            {
                HTTPError error = (HTTPError)code;
                Console.WriteLine($"Status: {error}");
            }
            else
            {
                Console.WriteLine("Invalid HTTP error code.");
            }
        }
    }
}