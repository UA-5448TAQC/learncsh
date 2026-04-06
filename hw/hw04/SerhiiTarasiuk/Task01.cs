using HW_04.Helpers;

namespace HW_04
{
    internal class Task01
    {
        public static void Run()
        {
            Console.WriteLine("Enter a string:");
            string stringValue = Console.ReadLine() ?? string.Empty;

            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;

            foreach (char c in stringValue)
            {
                char lower = char.ToLower(c);

                if (lower == 'a') countA++;
                if (lower == 'o') countO++;
                if (lower == 'i') countI++;
                if (lower == 'e') countE++;
            }

            Console.WriteLine("Following string {0} has: ", stringValue);
            Console.WriteLine($"{countA} - 'a' letters");
            Console.WriteLine($"{countO} - 'o' letters");
            Console.WriteLine($"{countI} - 'i' letters");
            Console.WriteLine($"{countE} - 'e' letters");
            Console.WriteLine("* all upper and lower case letters are counted");
        }
    }
}