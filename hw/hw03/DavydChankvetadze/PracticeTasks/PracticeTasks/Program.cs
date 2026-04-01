namespace FloatNumbersInRange;

internal class FloatNumberInRange
{
    public FloatNumberInRange(float firstNumber, float secondNumber, float thirdNumber)
    {
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        float firstNumber;
        while (!float.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid float number:");
        }

        Console.WriteLine("Enter the second number:");
        float secondNumber;
        while (!float.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid float number:");
        }

        Console.WriteLine("Enter the third number:");
        float thirdNumber;
        while (!float.TryParse(Console.ReadLine(), out thirdNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid float number:");
        }

        FloatNumberInRange floatNumbersInRange =
            new FloatNumberInRange(firstNumber, secondNumber, thirdNumber);

        if (IsInRange(firstNumber) && IsInRange(secondNumber) && IsInRange(thirdNumber))
        {
            Console.WriteLine("All numbers belong to the range [-5; 5].");
        }
        else
        {
            Console.WriteLine("Not all numbers belong to the range [-5; 5].");
        }
    }

    static bool IsInRange(float number)
    {
        return number >= -5 && number <= 5;
    }
}

