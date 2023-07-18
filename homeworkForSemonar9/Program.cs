using System;
namespace Seminar9
{
	class Program9
	{
		static void Main()
		{
			// ==================задача1==============
			// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
			// System.Console.WriteLine("Please, enter number1 for recursion");
			// int num1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter number2 for recursion");
			// int num2 = Convert.ToInt32(Console.ReadLine());
			// RecurtionFromTo(num1, num2);
			// ==================задача1==============
			// ==================задача2==============
			// Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
			// System.Console.WriteLine("Please, enter number1 for recursion");
			// int num1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter number2 for recursion");
			// int num2 = Convert.ToInt32(Console.ReadLine());
			// int result = RecurtionFromTo(num1, num2);
			// System.Console.WriteLine(result);
			// ==================задача2==============
			// ==================задача3==============
			// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
			// System.Console.WriteLine("Please, enter number1 for recursion");
			// int num1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter number2 for recursion");
			// int num2 = Convert.ToInt32(Console.ReadLine());
			// int result = AkkermanFunc(num1, num2);
			// System.Console.WriteLine(result);
			// ==================задача3==============
		}
		// ==================задача1==============
		// public static void RecurtionFromTo(int num1, int num2)
		// {
		// 	System.Console.WriteLine(num1);
		// 	if (num1 > num2) RecurtionFromTo(num1 - 1, num2);
		// 	if (num1 < num2) RecurtionFromTo(num1 + 1, num2);
		// }
		// ==================задача1==============
		// // ==================задача2==============
		// public static int RecurtionFromTo(int num1, int num2)
		// {
		// 	if (num1 > num2)
		// 	{
		// 		System.Console.WriteLine(num1);
		// 		return RecurtionFromTo(num1 - 1, num2) + num1;
		// 	}
		// 	if (num1 < num2)
		// 	{
		// 		System.Console.WriteLine(num2);
		// 		return RecurtionFromTo(num1, num2 - 1) + num2;
		// 	}
		// 	if (num1 == num2) return num2;
		// 	return 0;
		// }
		// ==================задача2==============
		// ==================задача3==============
		// public static int AkkermanFunc(int num1, int num2)
		// {
		// 	if (num1 == 0) return num2 + 1;
		// 	if (num1 > 0 && num2 == 0) return AkkermanFunc(num1 - 1, 1);
		// 	if (num1 > 0 && num2 > 0) return AkkermanFunc(num1 - 1, AkkermanFunc(num1, num2 - 1));
		// 	return 0;
		// }
		// ==================задача3==============
	}
}