using System;
namespace Seminar7
{
	class Program7
	{
		static void Main()
		{
			// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
			// System.Console.WriteLine("Enter namber: ");
			// int number = Convert.ToInt32(Console.ReadLine());
			// ShowNumbers(number);

			// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
			// System.Console.WriteLine("Enter namber: ");
			// int number = Convert.ToInt32(Console.ReadLine());
			// int result = SummNumbers(number);
			// System.Console.WriteLine(result);

			// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
			// System.Console.WriteLine("Enter namber: ");
			// int num1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter namber: ");
			// int num2 = Convert.ToInt32(Console.ReadLine());
			// SummNumbers(num1, num2);

			// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
			// System.Console.WriteLine("Enter namber: ");
			// int num1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter namber: ");
			// int num2 = Convert.ToInt32(Console.ReadLine());
			// double result = SummNumbers(num1, num2);
			// System.Console.WriteLine(result);

			//=========================================================================
			Console.Clear();
			Console.Write("Введите кол-во элементов: ");
			int n = int.Parse(Console.ReadLine()!);
			int[] array = new int[n];
			for (int i = 0; i < array.Length; i++)
				array[i] = new Random().Next(1, 101);
			Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
			Quicksort(array, 0, array.Length - 1);
			Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
			//=========================================================================
		}
		// public static void ShowNumbers(int number)
		// {
		// 	if (number == 0) return;
		// 	ShowNumbers(number - 1);
		// 	System.Console.Write(number);
		// }
		// public static int SummNumbers(int number)
		// {
		// 	if (number != 0) return SummNumbers(number / 10) + number % 10;
		// 	return 0;
		// }
		// public static void SummNumbers(int num1, int num2)
		// {
		// 	System.Console.WriteLine(num1);
		// 	if (num1 > num2) SummNumbers(num1 - 1, num2);
		// 	if (num1 < num2) SummNumbers(num1 + 1, num2);
		// }
		// public static double SummNumbers(int num1, int num2)
		// {
		// 	if (num2 > 0 && num2 != 0) return SummNumbers(num1, num2 - 1) * num1;
		// 	if (num2 < 0 && num2 != 0) return SummNumbers(num1, num2 + 1) / num1;
		// 	return 1;
		// }
		//=========================================================================
		public static int Partition(int[] array, int start, int end) // [1, 2, 4, 5, 3] 2 4
		{
			int marker = start; // Индекс опорного элемента 2
			for (int i = start; i < end; i++)
			{
				if (array[i] < array[end])
				{
					(array[marker], array[i]) = (array[i], array[marker]);
					marker++; // Получаем индекс числа большего, чем последнее + меняем местами числа, меньшие последнего, выносим в начало.
				}
			}
			// Мы получили индекс большего и поменяли местами больший с последним, последний больше предыдущих, тк был if
			(array[marker], array[end]) = (array[end], array[marker]);
			return marker;
		}


		public static void Quicksort(int[] array, int start, int end) // [5, 3, 4, 1, 2] 0 4
		{
			if (start >= end)
				return;

			int pivot = Partition(array, start, end); //индекс клочества замен в if
			System.Console.WriteLine(pivot);
			Quicksort(array, start, pivot - 1);
			Quicksort(array, pivot + 1, end); // [1, 2, 3, 4, 5] 3 4
		}
		//=========================================================================
	}
}