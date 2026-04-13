namespace Task3;
    enum HTTPError
{
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402,
    Forbidden = 403,
    NotFound = 404
}
    internal class Program
     {
        static void Main(string[] args)
            {
            Console.Write("Enter the HTTP error code: ");
            int errorcode = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(HTTPError), errorcode))
                {
                    HTTPError error = (HTTPError)errorcode;
                    Console.WriteLine($"Error name: {error}");
                }
            else 
                {
            Console.WriteLine("Unknown HTTP error code.");
                }
             }
}  

