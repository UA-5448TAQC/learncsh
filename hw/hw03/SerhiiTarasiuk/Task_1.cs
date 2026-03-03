namespace ConsoleApp1
{
    internal class Task_1
    {
         static void Main(string[] args)
        {
            float num1 = ReadFloat("Enter the first number: ");
            float num2 = ReadFloat("Enter the second number: ");
            float num3 = ReadFloat("Enter the third number: ");

            if (IsInRange(num1) && IsInRange(num2) && IsInRange(num3))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("All numbers are in the range [-5; 5].");
                Console.ResetColor();
            }
            else
            {   Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not all numbers are in the range [-5; 5].");
                Console.ResetColor();
            }

            bool IsInRange(float num)
            {
                return num >= -5 && num <= 5;
            }

            static float ReadFloat(string message)
            {
                while (true)
                {
                    Console.WriteLine(message);
                    string input = Console.ReadLine();

                    if (float.TryParse(input, out float result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Only float numbers.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
