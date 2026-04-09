namespace hw3_Zoriana_Telychko;

enum HTTPError
{
    Success = 200,
    Accepted = 201,
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402,
    Forbidden = 403,
    NotFound = 404,
    InternalServerError = 500
}

internal class Task3

{
    static void Main(string[] args)

    {
        Console.Write("Enter HTTP Error Code: ");
        string user_input = Console.ReadLine();

        if (int.TryParse(user_input, out int user_errorCode))
        {
            if (Enum.IsDefined(typeof(HTTPError), user_errorCode))
            { 
                    HTTPError error = (HTTPError)user_errorCode;
                    Console.WriteLine($"The error name is: {error}");
            }
            
            else
            {
                Console.WriteLine("Error: This code is not defined.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a numeric code.");
        }
    }
}


