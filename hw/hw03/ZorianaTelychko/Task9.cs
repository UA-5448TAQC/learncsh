using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Principal;
using System.Text;

namespace hw3_Zoriana_Telychko
{
    struct RGB
    {
        public byte Red;
        public byte Green;
        public byte Blue;
        public RGB(byte red, byte green, byte blue) 
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        public override string ToString()
        {
            return $"RGB({Red}, {Green}, {Blue})";
        }
    }
    internal class Task9
    {
        // Determine struct RGB that represents the color with fields red, green, blue (type byte)
        // Identify two variables of this type and enter their fields for white and black colors.

        private static void Main(string[] args)
        {
            RGB white = new RGB(255, 255, 255);
            RGB black = new RGB(0, 0, 0);
            Console.WriteLine($"White color: {white}");
            Console.WriteLine($"Black color: {black}");
         
            
        }

          

    }
}
