using System;

class Example
{
    public int Number
    {
	get;
	set;
    }
}

class Program
{
    static void Main()
    {
	Example example = new Example();
	example.Number = 8;
	example.Number *= 4;
	Console.WriteLine(example.Number);
    }
}
