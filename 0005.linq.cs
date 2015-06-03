using System;
using System.Linq;

class Program
{
    static void Main()
    {
	int[] array = { 1, 2, 3, 6, 7, 8 };
	// Query expression.
	var elements = from element in array
		       orderby element descending
		       where element > 2
		       select element;
	// Enumerate.
	foreach (var element in elements)
	{
	    Console.Write(element);
	    Console.Write(' ');
	}
	Console.WriteLine();
    }
}
