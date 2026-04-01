using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace hw2_Zoriana_Telychko_new
{
    internal class Task6
    {
        private static void Main(string[] args)
        // 5 - Define string name and integer age.Output question "What is your name?";
        // Read value name and output next question: "How old are you, (name)?"
        // Read value age and output whole information


        { 
            string name;
            int age;
            
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name}?");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age:  {age} years old");
        }
    }
}
