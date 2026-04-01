using System;
public class Staff : Person //class//
{
    public Staff() //default constructor//
    {
    }
    public Staff(string name, int salary) : base(name) //constructor//
    {
        Salary = salary; //property assignment//
    }
    public int Salary { get; set; } //property//
}
