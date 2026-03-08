using HW_04.Helpers;

namespace HW_04
{
    internal class Task04
    {
        public static void Run()
        {
            int a = ProgramHelpers.ReadInt("Enter integer a:");
            int b = ProgramHelpers.ReadInt("Enter integer b:");
            if (a > b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid range. 'a' should be less than or equal to 'b'.");
                Console.ResetColor();
                return;
            }
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of numbers in [{a}..{b}] divisible by 3: {count}");
        }
    }
}
