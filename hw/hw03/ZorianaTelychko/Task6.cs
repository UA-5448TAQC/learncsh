
namespace hw3_Zoriana_Telychko
{
    // Enter double number and get the first 2 digits after the point of this number and
    // output the sum of these numbers.For example: 3.456 -> 4+5=9
    public class Task6
    {
        private static void Main(string[] args)

       {
        Console.WriteLine("Enter double number: ");
        double entered_number = double.Parse(Console.ReadLine());
        double first_digit = (int)(entered_number * 10) % 10;
        double second_digit = (int)(entered_number * 100) % 10;
        double sum = first_digit + second_digit;
        Console.WriteLine($"The sum of the first two digits after the decimal point is: {first_digit} + {second_digit} = {sum}");    
        }
    }
}
    

