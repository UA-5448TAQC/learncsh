namespace HW_3
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second value:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            float c = float.Parse(Console.ReadLine());
            string answer = a >= -5 && a <= 5 && b >= -5 && b <= 5 && c >= -5 && c <= 5
                ? "All numbers are within the range [-5; 5]."
                : "At least one number is outside the range [-5; 5].";
            Console.WriteLine(answer);
        }
    }
}