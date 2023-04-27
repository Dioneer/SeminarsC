using System;
namespace Homework6
{
	class Programm6
	{
		static void Main()
		{
			// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
			// =========задача1=====================
			// System.Console.WriteLine("Please, enter array length: ");
			// int lengtn = Convert.ToInt32(Console.ReadLine());
			// int[] array = Array(lengtn);
			// System.Console.WriteLine($"Your pluse count is: {count(array)}");
			// =========задача1=====================
			// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
			// =========задача2=====================
			// System.Console.WriteLine("Please, enter coord k1: ");
			// double k1 = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please, enter coord k2: ");
			// double k2 = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please, enter coord d1: ");
			// double d1 = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please, enter coord d2: ");
			// double d2 = Convert.ToDouble(Console.ReadLine());
			// double[] arrayK = newKArray(k1, k2);
			// double[] arrayD = newDArray(d1, d2);
			// double[] result = findCoord(arrayK, arrayD);
			// showCoord(result);
			// =========задача2=====================
		}
		// =========задача1=====================
		// public static int[] Array(int length)
		// {
		// 	int[] array = new int[length];
		// 	for (int i = 0; i < length; i++)
		// 	{
		// 		System.Console.WriteLine("Enter numbers");
		// 		int input = Convert.ToInt32(Console.ReadLine());
		// 		array[i] = input;
		// 	}
		// 	return array;
		// }
		// public static int count(int[] array)
		// {
		// 	int count = 0;
		// 	foreach (int item in array)
		// 	{
		// 		if (item > 0)
		// 		{
		// 			count++;
		// 		}
		// 	}
		// 	return count;
		// }
		// =========задача1=====================
		// =========задача2=====================
		// public static double[] newKArray(double num1, double num2)
		// {
		// 	double[] array = { num1, num2 };
		// 	return array;
		// }
		// public static double[] newDArray(double num3, double num4)
		// {
		// 	double[] array = { num3, num4 };
		// 	return array;
		// }
		// public static double[] findCoord(double[] arrayK, double[] arrayD)
		// {
		// 	double coordX = (arrayD[1] - arrayD[0]) / (arrayK[0] - arrayK[1]);
		// 	double coordY = arrayK[1] * coordX + arrayD[1];
		// 	double[] coord = { coordX, coordY };
		// 	return coord;
		// }
		// public static void showCoord(double[] arr)
		// {
		// 	for (int i = 0; i < arr.Length; i++)
		// 	{
		// 		if (i == 0)
		// 		{
		// 			System.Console.Write("Your coords are: (");
		// 			System.Console.Write($"{arr[i]}");
		// 		}
		// 		else System.Console.Write($", {arr[i]}");
		// 	}
		// 	System.Console.Write(")");
		// }
		// =========задача2=====================
	}
}