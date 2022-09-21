using System;
using System.Collections.Generic;
using Prime.Models;

namespace Prime
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Input any number below 360 and we'll tell you prime numbers up to said");
			string userInput = Console.ReadLine();
      int input = Int32.Parse(userInput);
      Checker testVar = new Checker();
			Console.WriteLine(testVar.showPrimes(input));
		}
	}
}
