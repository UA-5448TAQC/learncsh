using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Plane(string mark, int highfly) : IFlyable
    {
        public string Mark { get; set; } = mark;
        public int HighFly { get; set; } = highfly;
        public void Fly() 
        {
            Console.WriteLine($"Plane: {Mark} flies at {HighFly} meters.");
        }   
    }
}
