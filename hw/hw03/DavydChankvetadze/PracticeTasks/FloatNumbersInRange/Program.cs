namespace FloatNumbersInRange;

internal class Program
{
    static void Main(string[] args)
    {
        float firstNumber = EnterFloatValue("first");
        float secondNumber = EnterFloatValue("second");
        float thirdNumber = EnterFloatValue("third");

        if (IsInRange(firstNumber) && IsInRange(secondNumber) && IsInRange(thirdNumber))
        {
            Console.WriteLine("All numbers belong to the range [-5; 5].");
        }
        else
        {
            Console.WriteLine("Not all numbers belong to the range [-5; 5].");
        }
    }
    
    private static float EnterFloatValue(string position)
    {
        do
        {
            Console.WriteLine($"Enter the {position} number:");

            if (float.TryParse(Console.ReadLine() ?? string.Empty, out float result))
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a valid float number.");
        }
        while (true);
    }

    private static bool IsInRange(float number)
    {
        return number >= -5 && number <= 5;
    }

}
