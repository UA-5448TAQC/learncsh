namespace Car
{
    internal class Car
    {
        private string name;
        private string color;
        private double price;
        public const string CompanyName = "DefaultCompany";

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {
            name = "Unknown";
            color = "white";
            price = 0;
        }

        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public void Input()
        {
            name = Helpers.ProgramHelpers.ReadNonEmptyString("Enter car name: ");
            color = Helpers.ProgramHelpers.ReadNonEmptyString("Enter car color: ");
            price = Helpers.ProgramHelpers.ReadPositiveDouble("Enter car price: ");
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Price: {price:F2}");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine();
        }

        public void ChangePrice(double x)
        {
            price += price * x / 100.0;
        }

        public void Repaint(string newColor)
        {
            if (string.Equals(color.ToLower(), "white"))
            {
                color = newColor;
                Console.WriteLine("Car repainted successfully.");
            }
            else
            {
                Console.WriteLine("Repaint is impossible.");
            }
        }

        public override string ToString()
        {
            return $@"

                                   _..-------++._
                               _.-'/ |      _||  \""--._
                         __.--'`._/_\j_____/_||___\    `----.
                    _.--'_____    |          \     _____    /
                  _j    /,---.\   |        =o |   /,---.\   |_
                 [__]==// .-. \\==`===========/==// .-. \\=[__]
                   `-._|\ `-' /|___\_________/___|\ `-' /|_.'  >>> Wroom-wroom !!!
                         `---'                     `---'

            Name: {name}, Color: {color}, Price: {price}";
        }


        public static bool operator == (Car? a, Car? b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.name == b.name && a.price == b.price;
        }

        public static bool operator !=(Car? a, Car? b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Car other)
            {
                return this == other;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, price);
        }
    }
}
