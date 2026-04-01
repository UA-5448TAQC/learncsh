namespace HW_3
{
    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return $"{name} is a {mark} and is {age} years old.";
        }
    }
    internal class Task_4
    {
        static void Main(string[] args)
        {
            Dog myDog;
            Console.WriteLine("Enter dog name:");
            myDog.name = Console.ReadLine();

            Console.WriteLine("Enter dog mark:");
            myDog.mark = Console.ReadLine();

            Console.WriteLine("Enter dog age:");
            myDog.age = int.Parse(Console.ReadLine());

            Console.WriteLine(myDog);
        }
    }
}
