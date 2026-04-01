using System;

public class Teacher : Staff //class//
{
    public string Subject { get; set; } //property//
    public Teacher() //default constructor//
    {
	}
   
    public Teacher(string name, int salary, string subject) : base(name, salary) //constructor//
    {
        Subject = subject; //property assignment//
    }


    public override void Print() //method//
    {
        Console.WriteLine($"Teacher: {Name}, Salary: {Salary}, Subject: {Subject}"); //method body//
    }

    public override string ToString() //method//
    {
        return ($"Teacher: {Name}, Salary: {Salary}, Subject: {Subject}"); //method body//
    }
}
