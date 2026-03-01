//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace hw02_IrynaMykhailevych
//{
//    internal class Task6
//    {
//        static void Main()
//        {
//            string name = ReadName("What is your name?");

//            int age = ReadAge($"How old are you, {name}?");

//            Console.WriteLine($"Your name is {name} and you are {age} years old.");
//        }

//        static string ReadName(string message)
//        {
//            Console.WriteLine(message);

//            string name = Console.ReadLine();

//            while (string.IsNullOrWhiteSpace(name))
//            {
//                Console.WriteLine("Please enter your name:");
//                name = Console.ReadLine();
//            }

//            return name;
//        }

//        static int ReadAge(string message)
//        {
//            Console.WriteLine(message);
//            string input = Console.ReadLine();
//            int result;
//            while (!int.TryParse(input, out result) || result <= 0)
//            {
//                Console.WriteLine("Please enter correct age:");
//                input = Console.ReadLine();
//            }
//            return result;
//        }
//    }
//}