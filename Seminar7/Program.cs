using System;
namespace Seminar7
{
	class Program7
	{
		static void Main()
		{
			//======exe1====================
			// System.Console.WriteLine("Enter row: ");
			// int r1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter column: ");
			// int r2 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter min: ");
			// int r3 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter max: ");
			// int r4 = Convert.ToInt32(Console.ReadLine());
			// int[,] result = CRArray(r1, r2, r3, r4);
			// showArr(result);
			//======exe1====================
			//======exe2====================
			// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
			// System.Console.WriteLine("Enter row: ");
			// int r1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter column: ");
			// int r2 = Convert.ToInt32(Console.ReadLine());
			// int[,] result = createArray(r1, r2);
			// showArr(result);
			//======exe3====================
			// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i + j.Выведите полученный массив на экран.
			// System.Console.WriteLine("Enter row: ");
			// int r1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter column: ");
			// int r2 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter min: ");
			// int r3 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("enter max: ");
			// int r4 = Convert.ToInt32(Console.ReadLine());
			// int[,] result = CRArray(r1, r2, r3, r4);
			// EvenIndex(result);
			// showArr(result);
			//======exe4====================
			// Задайте двумерный массив.Найдите сумму элементов, находящихся на главной диагонали(с индексами (0,0); (1; 1) и т.д.
			System.Console.WriteLine("Enter row: ");
			int r1 = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("enter column: ");
			int r2 = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("enter min: ");
			int r3 = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("enter max: ");
			int r4 = Convert.ToInt32(Console.ReadLine());
			int[,] result = CRArray(r1, r2, r3, r4);
			int result2 = DiaSum(result);
			showArr(result, result2);
		}
		//======exe1====================
		// public static int[,] CRArray(int rows, int columns, int minvalue, int maxValue)
		// {
		// 	int[,] array = new int[rows, columns];
		// 	for (int i = 0; i < rows; i++)
		// 	{
		// 		for (int j = 0; j < columns; j++)
		// 		{
		// 			array[i, j] = new Random().Next(minvalue, maxValue);
		// 		}
		// 	}
		// 	return array;
		// }
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
		//======exe1====================
		//======exe2====================
		// public static int[,] createArray(int rows, int columns)
		// {
		// 	int[,] array = new int[rows, columns];
		// 	for (int i = 0; i < rows; i++)
		// 	{
		// 		for (int j = 0; j < columns; j++)
		// 		{
		// 			array[i, j] = i + j;
		// 		}
		// 	}
		// 	return array;
		// }
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
		//======exe3====================
		// public static int[,] CRArray(int rows, int columns, int minvalue, int maxValue)
		// {
		// 	int[,] array = new int[rows, columns];
		// 	for (int i = 0; i < rows; i++)
		// 	{
		// 		for (int j = 0; j < columns; j++)
		// 		{
		// 			array[i, j] = new Random().Next(minvalue, maxValue);
		// 		}
		// 	}
		// 	return array;
		// }
		// public static void EvenIndex(int[,] array)
		// {
		// 	for (int i = 0; i < array.GetLength(0); i += 2)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j += 2)
		// 		{
		// 			array[i, j] *= array[i, j];
		// 		}
		// 	}
		// }
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
		//======exe4====================
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
		public static int DiaSum(int[,] array)
		{
			int sum = array[0, 0];
			for (int i = 1; i < array.GetLength(0) && i < array.GetLength(1); i++)
			{
				sum += array[i, i];
			}
			return sum;
		}
		public static void showArr(int[,] array, int res)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					System.Console.Write(array[i, j] + " ");
				}
				System.Console.WriteLine();
			}
			System.Console.WriteLine(res);
		}
	}
}