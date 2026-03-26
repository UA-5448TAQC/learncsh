namespace ConsoleApp5
{
    internal class Program
    {
        //public static int f(int a) {
        //    try
        //    {
        //        return a + 1;
        //    }
        //    finally
        //    {
        //        //return a; // This will override the return value from the try block, which is generally not recommended
        //    }  
        //    return 0;
        //}
        public static int ReadInt()
        {
            Console.WriteLine("Enter a number:");
            string msg = Console.ReadLine();
            int a = int.Parse(msg);
            if (a == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a;
        }
        static void Main(string[] args)
        {
            //a = "Hello, World!"; // This will cause a compile-time error due to type mismatch
            //int a = 0;
            //int b = 15;
            //int c = 0;
            //try
            //{
            //    c = b / a;
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e);
            //    Console.WriteLine($"Caught an exception: {e.Message}");
            //    Console.WriteLine($"Stack Trace: {e.StackTrace}");
            //    c = -100;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    Console.WriteLine($"Caught an exception: {e.Message}");
            //    Console.WriteLine($"Stack Trace: {e.StackTrace}");
            //    c = -100;
            //}

            //try
            //{
            //    //Console.WriteLine("Enter a number:");
            //    //string msg = Console.ReadLine();
            //    //int a = int.Parse(msg);
            //    //if (a == 0)
            //    //{
            //    //    throw new DivideByZeroException("Cannot divide by zero.");
            //    //}
            //    int b = ReadInt();
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Caught a DivideByZeroException: {ex.Message}");
            //}
            //catch
            //{
            //    Console.WriteLine("Caught a general exception.");
            //}


            //DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach (DriveInfo drive in drives)
            //{
            //    Console.WriteLine($"Name Drives: {drive.Name}");
            //    Console.WriteLine($"Drive Type: {drive.DriveType}");

            //}

            string path = @"C:\data\csh\temp";
            //string path2 = "C:\\data\\csh";

            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {

                dir.Create();
                Console.WriteLine($"Directory created at: {dir.FullName}");
            }
            Console.WriteLine($"Directory exists at: {dir.FullName}");
            Console.WriteLine("Enter a file name:");
            string fileName = Console.ReadLine();
            FileInfo file = new FileInfo(Path.Combine(path, fileName));
            if (!file.Exists)
            {
                Console.WriteLine($"File does not exist at: {file.FullName}");
                file.Create().Close(); // Create the file and close the stream immediately
                Console.WriteLine($"File created at: {file.FullName}");
            }
            else
            {
                StreamReader reader = new StreamReader(file.FullName);
                string line;

                LinkedList<string> list = new LinkedList<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"line: {line}");
                    // Do something with the line.
                    foreach (string part in line.Split(',')) { 
                        list.AddLast(part.Trim());
                    };

                }
                reader.Close();
                foreach (string part in list)
                {
                    Console.WriteLine($"part: {part}");
                }

            }

        }


        //Console.WriteLine("c ={0}", c);
    }
    
}
