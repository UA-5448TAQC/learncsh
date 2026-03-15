namespace Car
{
    internal class ProgramCar
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine("Enter data for car 1:");
            car1.Input();

            Console.WriteLine("\nEnter data for car 2:");
            car2.Input();

            Console.WriteLine("\nEnter data for car 3:");
            car3.Input();

            Console.WriteLine("\n--- Cars before price change ---");
            car1.Print();
            car2.Print();
            car3.Print();

            car1.ChangePrice(-10);
            car2.ChangePrice(-10);
            car3.ChangePrice(-10);

            Console.WriteLine("\n--- Cars after decreasing price by 10% ---");
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);

            string newColor = HW_05.Helpers.ProgramHelpers.ReadNonEmptyString("Enter new color: ");
            car1.Repaint(newColor);

            Console.WriteLine("\n--- Car1 after repaint ---");
            Console.WriteLine(car1);

        }
    }
}
