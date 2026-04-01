using System.Collections;
using System.ComponentModel;

namespace ConsoleApp3
{

    internal class Program
    {
        public interface IMyInterface
        {
            void MyMethod();
            void PrintName(string name)
            {
                Console.WriteLine("Hello, " + name + "!");
            }

        }

        public interface IMyInterface2
        {
            void MyMethod22();
            void PrintName(string v);
        }

        public class MyClass : IMyInterface, IMyInterface2
        {
            public void MyMethod()
            {
                Console.WriteLine("Hello from MyMethod!");
            }
            public void MyMethod2()
            {
            }

            public void MyMethod22()
            {
                throw new NotImplementedException();
            }
            public void PrintName(string name)
            {
                Console.WriteLine("Hello from MyClass, " + name + "!");
            }
        }
        public class MyClass2 : IMyInterface
        {
            public void MyMethod()
            {
                Console.WriteLine("Hello from MyMethod in MyClass2!");
            }
            public int MyMethod3()
            {
                return 42;
            }
        }


        static void Main(string[] args)
        {
            IMyInterface2 i1 = new MyClass();
            IMyInterface i2 = new MyClass2();
            MyClass myClass = new MyClass();
            i1.PrintName("Bob");
            i2.PrintName("Alice");

            List<IMyInterface> myList = new List<IMyInterface>();
            myList.Add(new MyClass());
            myList.Add(new MyClass2());
            Dictionary<string, IMyInterface> myDictionary = new Dictionary<string, IMyInterface>();

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(new MyClass());
            myArrayList.Add(1);
            myArrayList.Add("new MyClass()");
            myArrayList.Add(new MyClass());
            //myArrayList.Insert(100, new MyClass()); // This will throw an ArgumentOutOfRangeException because the index is greater than the current size of the ArrayList.
            myArrayList.Remove("new MyClass()");
            Dictionary<string, string> domain = new Dictionary<string, string>();
            domain.Add("google", "google.com");
            domain.Add("facebook", "facebook.com");
            domain.Add("twitter", "twitter.com");
            Console.WriteLine(domain.Count);
            Console.WriteLine(domain["google"]);
            Console.WriteLine(domain["facebook"]);
            foreach (var item in domain)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            //myClass.MyMethod2();
            //(MyClass)myInterface1.MyMethod2();


        }
    }
}
