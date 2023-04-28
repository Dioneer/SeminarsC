using System;
namespace Homework5
{
	class Programm5
	{
		static void Main()
		{
			// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
			//======= Сами функции в файле exe34.cs==================
			// System.Console.WriteLine("let's find out the number of even numbers in the array.");
			// System.Console.WriteLine("Please enter length of the array: ");
			// int length = Convert.ToInt32(Console.ReadLine());
			// PlusCounter counter = new PlusCounter();
			// int[] randomArr = counter.randomArray(length);
			// counter.showArr(randomArr);
			// int result = counter.counter(randomArr);
			// System.Console.WriteLine($"The number of even numbers is: {result}");
			//======= Сами функции в файле exe34.cs==================

			// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
			//======= Сами функции в файле exe36.cs==================
			// System.Console.WriteLine("let's find out the summ of the odd index numbers.");
			// System.Console.WriteLine("Please enter length of the array: ");
			// int length = Convert.ToInt32(Console.ReadLine());
			// SummOdd summ = new SummOdd();
			// int[] randomArr = summ.randomArray(length);
			// int result = summ.summFunc(randomArr);
			// Console.WriteLine($"The number of even numbers is: {result}");
			//======= Сами функции в файле exe36.cs==================

			// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
			//======= Сами функции в файле exe38.cs==================
			// System.Console.WriteLine("let's find out difference between the maximum and minimum array elements.");
			// System.Console.WriteLine("Please enter length of the array: ");
			// int length = Convert.ToInt32(Console.ReadLine());
			// MinMax sumMinMax = new MinMax();
			// double[] randomArr = sumMinMax.randomArray(length);
			// double[] mmArray = sumMinMax.minmax(randomArr);
			// double result = sumMinMax.diff(mmArray);
			// Console.WriteLine($"The difference between the maximum and minimum array elements. is: {result}");
			//======= Сами функции в файле exe38.cs==================
			//======= Это помощь, к делу не относится==================
			// 	Console.Write("Input a quantity of elements: ");
			// 	int size = Convert.ToInt32(Console.ReadLine());
			// 	Console.Write("Input a minimum possible element: ");
			// 	double min = Convert.ToDouble(Console.ReadLine());
			// 	Console.Write("Input a maximum possible element: ");
			// 	double max = Convert.ToDouble(Console.ReadLine());
			// 	double[] array = CreateRandomArray(size, min, max);
			// 	ShowArray(array);
			// 	System.Console.WriteLine();
			// 	double diff = Math.Round(GetDiffOfNumbers(array), 2);
			// 	Console.WriteLine($"Difference between max and min is -> {diff} ");
			// }
			// public static double[] CreateRandomArray(int size, double minValue, double maxValue)
			// {
			// 	double[] array = new double[size];
			// 	Random random = new Random();

			// 	for (int i = 0; i < size; i++)
			// 		array[i] = random.NextDouble() * (maxValue - minValue) + minValue;

			// 	return array;
			// }


			// public static void ShowArray(double[] array)
			// {
			// 	Console.Write($"New array: [{array[0]}");

			// 	for (int i = 1; i < array.Length; i++)

			// 		Console.Write($" {array[i]}");
			// 	Console.Write("]");
			// }

			// public static double GetDiffOfNumbers(double[] array)
			// {
			// 	double min = 0;
			// 	double max = 0;
			// 	for (int i = 0; i < array.Length; i++)
			// 	{
			// 		if (array[i] > max) max = array[i];
			// 		else if (array[i] < min) min = array[i];
			// 	}

			// 	return max - min;
			// }

		}
	}