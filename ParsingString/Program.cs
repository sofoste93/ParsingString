using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingString
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;

			string myString = "1618";
			string newString = "101";

			// parse string in to integer
			int num1 = int.Parse(myString);
			int num2 = int.Parse(newString);

			// set result..types
			int resultInteger = num1 + num2;
			string resultString = myString + newString;

			Console.WriteLine("Initial values: " + myString + " & " + newString + "\n");
			Console.WriteLine("Summirized: " + resultInteger);
			Console.WriteLine("Concatenated: " + resultString);
			Console.ReadKey();
		}
	}
}
