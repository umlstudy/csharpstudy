// http://www.dotnetperls.com/property

using System;
using System.Diagnostics;

class Program
{
    static string _backing; // Backing store for property.
    static string Property // Getter and setter.
    {
	get
	{
	    return _backing;
	}
	set
	{
	    _backing = value;
	}
    }
    static string Field; // Static field.

    static void Main()
    {
	const int m = 100000000;
	for (int x = 0; x < 10; x++) // Ten tests.
	{
	    Stopwatch s1 = new Stopwatch();
	    s1.Start();
	    for (int i = 0; i < m; i++) // Test property.
	    {
		Property = "string";
		if (Property == "cat")
		{
		}
	    }
	    s1.Stop();
	    Stopwatch s2 = new Stopwatch();
	    s2.Start();
	    for (int i = 0; i < m; i++) // Test field.
	    {
		Field = "string";
		if (Field == "cat")
		{
		}
	    }
	    s2.Stop();
	    Console.WriteLine("{0},{1}",
		s1.ElapsedMilliseconds,
		s2.ElapsedMilliseconds);
	}
	Console.Read();
    }
}
