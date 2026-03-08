using HW_04.Helpers;
namespace HW_04
{
    internal class Task05
    {
        public static void Run()
        {
            string input = ProgramHelpers.ReadNonEmptyString("Enter a string:");
            string result = string.Empty;
            for (int i = 1; i < input.Length; i += 2)
            {
                result += input[i];
            }
            if (input.Length == 1)
            {
                Console.WriteLine($"Your string is one char. So nothing to show");
            }
            else
            {
                Console.WriteLine($"Every second character of the string\n \"{input}\" >> {result}");
            }
        }
    }
}
