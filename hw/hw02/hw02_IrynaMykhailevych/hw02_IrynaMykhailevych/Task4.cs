//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Transactions;

//namespace hw02_IrynaMykhailevych
//{
//    internal class Task4
//    {
//        static void Main()
//        {
//            int number1 = ReadInt("Enter first integer:");
//            int number2 = ReadInt("Enter second integer:");

//            bool areBothPositive = (number1 > 0) && (number2 > 0);

//            Console.WriteLine("Are both numbers positive? " + areBothPositive);
//        }

//        static int ReadInt(string message)
//        {
//            Console.WriteLine(message);

//            string input = Console.ReadLine();
//            int result;

//            while (!int.TryParse(input, out result))
//            {
//                Console.WriteLine("Please enter a valid integer:");
//                input = Console.ReadLine();
//            }

//            return result;
//        }
//    }

//    }
