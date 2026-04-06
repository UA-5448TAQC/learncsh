namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();

            Console.WriteLine("Enter 7 pairs (ID Name):");

            for (int i = 0; i < 7; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (parts.Length == 2 && uint.TryParse(parts[0], out uint id))
                {
                    string name = parts[1];
                    persons[id] = name;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                    i--;
                }
            }

            Console.Write("Enter ID: ");
            string idInput = Console.ReadLine();

            if (uint.TryParse(idInput, out uint searchId))
            {
                if (persons.ContainsKey(searchId))
                {
                    Console.WriteLine("Name: " + persons[searchId]);
                }
                else
                {
                    Console.WriteLine("ID not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID format.");
            }
        }
    }
    }
}
