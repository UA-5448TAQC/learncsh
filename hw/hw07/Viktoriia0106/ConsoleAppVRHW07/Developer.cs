using System;

public class Developer : Staff //class//
{
    public string Level { get; set; } //property//
    public Developer() //default constructor//
    {
    }

    public Developer(string name, int salary, string level) : base(name, salary) //constructor//
    {
        Level = level; //property assignment//
    }


    public override void Print() //method//
    {
        Console.WriteLine($"Developer: {Name}, Salary: {Salary}, Level: {Level}"); //method body//
    }

    public override string ToString() //method//
    {
        return ($"Developer: {Name}, Salary: {Salary}, Level: {Level}"); //method body//
    }
}
