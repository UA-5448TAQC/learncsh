using System;

namespace Task3;

internal class Accountancy
{
    public void PayingFellowship(int mark)
    {
        if (mark >= 90)
            Console.WriteLine("Scholarship granted");
        else
            Console.WriteLine("No scholarship");
    }
}