using HTTPErrorEnum.Enums;

namespace HTTPErrorEnum;

internal class Program
{
    static void Main(string[] args)
    {
        int errorCode;
        Console.WriteLine("Enter an HTTP error code (400, 401, 402, 403, 404):");
        while (!int.TryParse(Console.ReadLine(), out errorCode) || !Enum.IsDefined(typeof(HTTPErrors), errorCode))
        {
            Console.WriteLine("Invalid input. Please enter a valid HTTP error code (400, 401, 402, 403, 404):");
        }
        Console.WriteLine($"The HTTP error code {errorCode} corresponds to: {Enum.GetName(typeof(HTTPErrors), errorCode)}");
    }
}
