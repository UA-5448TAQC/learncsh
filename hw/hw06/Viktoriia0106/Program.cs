   using System.Collections.Generic;
using System.Drawing;

namespace ConsoleAppVRHW06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecuteTask6_1();
            //ExecuteTask6_2();
            //ExecuteTask6_3();
            //ExecuteTask6_4();
        }
        static void ExecuteTask6_1()
        {
            List<IFlyable> items = new List<IFlyable>();
            items.Add(new Plane("Concorde", 18000));
            items.Add(new Plane("Boeing 747", 35000));
            items.Add(new Plane("Boeing 747", 35000));
            items.Add(new Plane("Airbus A380", 43000));
            items.Add(new Plane("Lockheed SR-71 Blackbird", 85000));
            items.Add(new Bird("Sparrow", true));
            items.Add(new Bird("Albatross", true));
            items.Add(new Bird("Penguin", false));
            items.Add(new Bird("Ostrich", false));
            items.Add(new Bird("Eagle", true));

            foreach (IFlyable item in items) //alternative: foreach (var item in items)//
            {
                item.Fly();
            }
        } 

        static void ExecuteTask6_2()
        {
            List<int> myColl = new List<int>();
            for (int i = 0; i < 10; i++) //10 times, start from 0, and increase by 1 till 9//
            {
                Console.WriteLine("Enter an integer value:");
                int inputValue = int.Parse(Console.ReadLine());
                myColl.Add(inputValue);
            }
            for (int i = 0; i < 10; i++)
            {
                if (myColl[i] == -10) //if the value is -10, then print it//
                { Console.WriteLine(i);
                }
            }
            for (int i = 9; i >= 0; i--)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                }
            }
            // position 8, value -3//
            int pos8 = 8;
            int valForPos8 = -3;
            if (myColl.Count > 8)
            {
                myColl.Insert(pos8, valForPos8); //Alternative without variables: myColl.Insert(8, -3);//
            }
            else
            {
                myColl.Add(-3); // If the list is too short, adding to the end
            }

            // position 5, value -4//
            int pos5 = 5;
            int valForPos5 = -4;
            if (myColl.Count > 5)
            {
                myColl.Insert(pos5, valForPos5); //Alternative without variables: myColl.Insert(5, -4);//
            }
            else
            {
                myColl.Add(-4); // If the list is too short, adding to the end
            }

            // position 2, value 1//
            int pos2 = 2;
            int valForPos2 = 1;
            if (myColl.Count > 2)
            {
                myColl.Insert(pos2, valForPos2); //Alternative without variables: myColl.Insert(2, 1);//
            }
            else
            {
                myColl.Add(1); // If the list is too short, adding to the end
            }

            //// If too many numbers > 20, list is too short for inserting, so error. To avoid error - if/else was added above.//
            ///Value -3 position 8//
            //int pos8 = 8;
            //int valForPos8 = -3;
            //myColl.Insert(pos8, valForPos8); //Alternative without variables: myColl.Insert(8, -3);//

            //// Value -4 position 5//
            //int pos5 = 5;
            //int valForPos5 = -4;
            //myColl.Insert(pos5, valForPos5); //Alternative without variables: myColl.Insert(5, -4);//

            //// Value 1 position 2//
            //int pos2 = 2;
            //int valForPos2 = 1;
            //myColl.Insert(pos2, valForPos2); //Alternative without variables: myColl.Insert(2, 1);//

            Console.WriteLine("Updated collection:");
            for (int i = 0; i < myColl.Count; i++)
            {
                Console.WriteLine("Position: " + i + ", Value: " + myColl[i]);
            }
            myColl.Sort(); // Sort the collection in ascending order//
            Console.WriteLine("Sorted collection:");
            for (int i = 0; i < myColl.Count; i++)
            {
                Console.WriteLine("Position: " + i + ", Value: " + myColl[i]);
            }
        }  
        static void ExecuteTask6_3()
        {
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("Java", "IntelliJ IDEA"));
            developers.Add(new Builder("Hammer"));
            developers.Add(new Builder("Screwdriver"));
            developers.Add(new Programmer("C#", "Visual Studio"));

            developers.Sort();

            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
                Console.WriteLine($"Tool used: {developer.Tool}");
                Console.WriteLine(); // Print an empty line for better readability
            }
        } 
        static void ExecuteTask6_4()
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            for (int i = 0; i < 7; i++)
            { Console.Write("Enter ID: ");
                uint id = uint.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                if (persons.ContainsKey(id))
                {
                    Console.WriteLine("ID already exists! Try again.");
                    i--; // i-- option for repeated entering ID in case it's not unique//
                }
                else
                {
                    persons.Add(id, name);
                }                
            }
            foreach (var person in persons) // Alternative: foreach (KeyValuePair<uint, string> person in persons)//
            {
                Console.WriteLine($"ID: {person.Key}, Name: {person.Value}");
            }
            Console.Write("Enter ID to find: ");
            uint searchId = uint.Parse(Console.ReadLine());

                        if (persons.ContainsKey(searchId))
            {
                Console.WriteLine($"Name: {persons[searchId]}");
            }
                else
                {
                    Console.WriteLine("ID not found.");
                }
            }
        }
    }






