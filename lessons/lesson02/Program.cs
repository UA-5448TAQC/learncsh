namespace ConsoleApp3
{
    internal class Program
    {

        static int Main(string[] args)
        {
            //Console.Write("tes1;");
            //Console.WriteLine("tes2;");
            //Console.WriteLine("Hello, World!");
            //int a = 1;
            //double b = 2.5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("a={0} b={1} a={0}", a, b);
            //Console.WriteLine("Currency format: {0:C}", 5555.5812);
            //Console.WriteLine("Datetime format: {0:d}, {0:t}", DateTime.Now);
            //Console.WriteLine("Float format (3 digits after point): {0:F3}", 1234.56789);
            //Console.WriteLine("Numerical format: {0:N1}", 5555.5812);
            //Console.WriteLine("16-X format: {0:X}", 5555);
            //Console.WriteLine("Press any key to continue...");

            //string name = Console.ReadLine();
            //string sAge = Console.ReadLine();
            //Console.WriteLine("My name is {0} age:{1}", name, sAge);
            //int age = System.Convert.ToInt16(sAge);
            //age += 1;
            //Console.WriteLine("My name is {0} age:{1}", name, age);

            Console.WriteLine("Enter a number:");
            string s = Console.ReadLine(); // "1234"
            int number;
            bool rez = Int32.TryParse(s, out number);
            Console.WriteLine("{0}-{1}", rez, number);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j < number; j++)
                {
                    Console.WriteLine(j);
                }
            }
            return 0;
        }
    }
}
