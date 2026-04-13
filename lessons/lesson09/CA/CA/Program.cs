namespace CA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            Adress adress1 = new Adress("Lviv", "Street1", "Ukraine", 79000);
            Adress adress2 = new Adress("Odesa", "Street2", "Ukraine", 79000);
            Person person1 = new Person("1", "Doe", adress1, 1990);
            Person person2 = new Person("2", "Doe", adress2, 1986);
            Person person3 = new Person("3", "Doe", adress1, 2001);

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            person3.Adress = adress2;

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }

    }
}
