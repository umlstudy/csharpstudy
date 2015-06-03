using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    const int _max = 1000000;
    static void Main()
    {
	int[] values = { 10, 0, 1, 1, 20, 300, 400, 4 };

	// Version 1: use LINQ.
	var s1 = Stopwatch.StartNew();
	for (int i = 0; i < _max; i++)
	{
	    int count = CountLinq(values);
	}
	s1.Stop();

	// Version 2: use for-loop.
	var s2 = Stopwatch.StartNew();
	for (int i = 0; i < _max; i++)
	{
	    int count = CountFor(values);
	}
	s2.Stop();
	Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
	    _max).ToString("0.00 ns"));
	Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
	    _max).ToString("0.00 ns"));
	Console.Read();
    }

    static int CountLinq(int[] values)
    {
	// Count values greater than or equal to 10 with LINQ.
	return (from x in values
		where x >= 10
		select x).Count();
    }

    static int CountFor(int[] values)
    {
	// Count values greater than or equal to 10 with a loop.
	int count = 0;
	for (int i = 0; i < values.Length; i++)
	{
	    if (values[i] >= 10)
	    {
		count++;
	    }
	}
	return count;
    }
}
