using System;
namespace Seminar7
{
	class Program7
	{
		static void Main()
		{
			// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
			// int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			// showArr(array);
			// ReverseArry(array);
			// showArr(array);
			// Задайте двумерный массив. Напишите программу, которая поменяет местами строки массива.
			// System.Console.WriteLine("Enter row: ");
			// int r1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter column: ");
			// int r2 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter min: ");
			// int r3 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter max: ");
			// int r4 = Convert.ToInt32(Console.ReadLine());
			// int[,] result = CRArray(r1, r2, r3, r4);
			// System.Console.WriteLine("Enter row1: ");
			// int row1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter row2: ");
			// int row2 = Convert.ToInt32(Console.ReadLine());
			// showArr(result);
			// changeRow(result, row1, row2);
			// System.Console.WriteLine("");
			// showArr(result);
			// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
			System.Console.WriteLine("Enter row: ");
			int r1 = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("enter column: ");
			int r2 = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("enter min: ");
			int r3 = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("enter max: ");
			int r4 = Convert.ToInt32(Console.ReadLine());
			int[,] result = CRArray(r1, r2, r3, r4);
			showArr(result);
			int[] res = MinimumElement(result);
			DeleteRowAndColumn(result, res);
			System.Console.WriteLine("");
			showArr(result);
		}
		// public static void showArr(int[,] array)
		// {
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			System.Console.Write(array[i, j] + " ");
		// 		}
		// 		System.Console.WriteLine();
		// 	}
		// }
		// public static void ReverseArry(int[,] array)
		// {
		// 	for (int i = 0; i < array.GetLength(0) - 1; i++)
		// 	{
		// 		for (int j = i + 1; j < array.GetLength(1); j++)
		// 		{
		// 			int temp = array[i, j];
		// 			array[i, j] = array[j, i];
		// 			array[j, i] = temp;
		// 		}
		// 	}

		// }

		public static int[,] CRArray(int rows, int columns, int minvalue, int maxValue)
		{
			int[,] array = new int[rows, columns];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					array[i, j] = new Random().Next(minvalue, maxValue);
				}
			}
			return array;
		}
		public static void showArr(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					System.Console.Write(array[i, j] + " ");
				}
				System.Console.WriteLine();
			}
		}
		// public static void changeRow(int[,] array, int row1, int row2)
		// {
		// 	if (row1 < array.GetLength(0) && row2 < array.GetLength(0) && row1 >= 0 && row2 >= 0)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			int temp = array[row1, j];
		// 			array[row1, j] = array[row2, j];
		// 			array[row2, j] = temp;
		// 		}
		// 	}
		// 	else { Console.WriteLine("error"); }
		// }
		// public static int[] MinimumElement(int[,] array)
		// {
		// 	int min = array[0, 0];
		// 	int minX = 0;
		// 	int minY = 0;
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			if (array[i, j] < min)
		// 			{
		// 				min = array[i, j];
		// 				minX = i;
		// 				minY = j;
		// 			}
		// 		}
		// 	}
		// 	int[] coord = { minX, minY };
		// 	return coord;
		// }

		// public static void DeleteRowAndColumn(int[,] array, int[] coord)
		// {
		// 	for (int i = 0; i < array.GetLength(0); i++) array[i, coord[1]] = 0;
		// 	for (int j = 0; j < array.GetLength(1); j++) array[coord[0], j] = 0;
		// }
	}
}
