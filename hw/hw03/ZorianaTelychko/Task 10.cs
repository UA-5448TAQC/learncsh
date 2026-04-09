using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace hw3_Zoriana_Telychko
{
    enum Food
    {
        Fish, Mouse, Meat, DryFood, Water
    }

    class Cat
    {
        private int fullnessLevel = 0;

        public int FullnessLevel
        {
            get { return fullnessLevel; }
        }

        public void Eat(Food food)
        {
            if (fullnessLevel >= 100)
            {
                Console.WriteLine("Не перегодовуй кота!");
                return;
            }

            switch (food)
            {
                case Food.Mouse: fullnessLevel += 10; break;
                case Food.Fish: fullnessLevel += 20; break;
                case Food.Meat: fullnessLevel += 30; break;
                case Food.DryFood: fullnessLevel += 40; break;
                case Food.Water: fullnessLevel += 5; break;
            }

            if (fullnessLevel > 100) fullnessLevel = 100;
        }
    } 

    
    class Task10
    {
        public static void Main(string[] args)
        {
            Cat myCat = new Cat();

            Console.WriteLine($"Start of the fullness level: {myCat.FullnessLevel}/100");

            Console.WriteLine("Giving mouse for the cat...");
            myCat.Eat(Food.Mouse);
            Console.WriteLine("Giving water for the cat...");
            myCat.Eat(Food.Water);

            Console.WriteLine($"New fullness level {myCat.FullnessLevel}/100");
        }
    }
} 




