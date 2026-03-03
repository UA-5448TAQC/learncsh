namespace ConsoleAppTasks.Models
{
    internal struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        public override string ToString()
        {
            return $"Name: {Name}, Mark: {Mark}, Age: {Age}";
        }
    }
}