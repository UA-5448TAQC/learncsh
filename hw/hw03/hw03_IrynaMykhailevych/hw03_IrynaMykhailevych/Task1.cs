using System;

namespace hw03_IrynaMykhailevych
{
    internal class Task1
    {
        static void Main()
        {
            float value1 = ReadFloat("Enter the first float value: ");
            float value2 = ReadFloat("Enter the second float value: ");
            float value3 = ReadFloat("Enter the third float value: ");

            bool allInRange = AreAllInRange(value1, value2, value3);

            PrintResult(allInRange);
        }
        static float ReadFloat(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            float result;

            while (!float.TryParse(input, out result))
            {
               Console.WriteLine("Invalid input. Please enter a valid float value:");
               input = Console.ReadLine();
            }
            return result;
        }
        static bool AreAllInRange(float value1, float value2, float value3)
        {
            return value1 >= -5 && value1 <= 5
                && value2 >= -5 && value2 <= 5
                && value3 >= -5 && value3 <= 5;
        }
        static void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("All values are within the range of -5 to 5.");
            }
            else
            {
                Console.WriteLine("At least one value is outside the range of -5 to 5.");
            }
        }
    }
}
