using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome");
		DoMath(10);
		DoMath(20);
		DoMath(30);
		DoMath(40);
		DoMath(50);
	}
	
	public void DoMath (int value) {
		var number = value + 2;
		Console.WriteLine(number);
	}
}
