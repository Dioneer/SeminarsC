﻿// Seminar 1
using System;

namespace Seminar1
{
	// class Program1
	// {
	// 	static void Main()
	// 	{
	// 		Console.Write("Input a first number: ");
	// 		int num1 = Convert.ToInt32(Console.ReadLine());
	// 		Console.Write("Input a second number: ");
	// 		int num2 = Convert.ToInt32(Console.ReadLine());
	// 		int quad2 = num2 * num2;

	// 		if (num1 == quad2)
	// 		{
	// 			Console.WriteLine("Correct");
	// 		}
	// 		else
	// 		{
	// 			Console.WriteLine("Uncorrect");
	// 		}
	// 	}
	// }
	class Program1
	{
		static void Main()
		{
			Console.Write("Input a number: ");
			int number = Convert.ToInt32(Console.ReadLine());
			int current = -number;
			while (current <= number)
			{
				Console.Write(current + " ");
				current++;
			}
		}
	}
}
