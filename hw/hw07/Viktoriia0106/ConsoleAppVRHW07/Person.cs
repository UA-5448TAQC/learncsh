using System;

public class Person
{
	public Person()
	{

	}
	public Person(string name)
	{ Name = name; }

	public string Name { get; set; }
	public virtual void Print()
	{ Console.WriteLine($"Name: {Name}");
	}

}
