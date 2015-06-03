using System;

class Study {

	delegate int MyDelegate(int a, int b);

	static MyDelegate add1 = delegate(int a, int b) 
	{
		return a+b;
	};

	static void Main() 
	{
		MyDelegate add = delegate(int a, int b) 
		{
			return a+b;
		};

		Console.WriteLine(add(1,3));
		Console.WriteLine(add(7,3));
		Console.WriteLine(add1(1,13));
	}
}
