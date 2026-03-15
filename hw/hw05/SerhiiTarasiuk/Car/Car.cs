namespace Car
{
    internal class Car
    {
        private string name;
        private string color;
        private double price;

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
            name =  Helpers.ProgramHelpers.ReadNonEmptyString("Enter car name: ");
            color = Helpers.ProgramHelpers.ReadNonEmptyString("Enter car color: ");
            price = Helpers.ProgramHelpers.ReadPositiveInt("Enter car price: ");
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Price: {price}");
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

       
    }
}
