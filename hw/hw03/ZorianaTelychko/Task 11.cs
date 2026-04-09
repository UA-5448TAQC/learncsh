using System;
using System.Collections.Generic;
using System.Text;

namespace hw3_Zoriana_Telychko
{
    struct Student
    {
        public string lastName;
        public string groupNumber;
    }
    class Task_11
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of students: ");
            int studentsCount = int.Parse(Console.ReadLine());

            Student[] students = new Student[studentsCount];

            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine($"\nEnter the student data {i + 1}:");

                Console.Write("Last Name: ");
                students[i].lastName = Console.ReadLine();

                Console.Write("Group number: ");
                students[i].groupNumber = Console.ReadLine();
            }

            Console.WriteLine("\n--- Student Search ---");
            Console.Write("Which group do you want to see? ");
            string targetGroup = Console.ReadLine();

            Console.Write("From which letter? ");
            string inputLetter = Console.ReadLine();
            char targetLetter = inputLetter[0];


            Console.WriteLine($"\nStudents from group {targetGroup} starting with '{targetLetter}':");

            for (int i = 0; i < studentsCount; i++)
            {

                if (students[i].groupNumber == targetGroup && students[i].lastName[0] == targetLetter)
                {
                    Console.WriteLine(students[i].lastName);
                }
            }

        }



    }
}





