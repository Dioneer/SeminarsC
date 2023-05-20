using System;
namespace Homework8
{
	class Programm8
	{
		static void Main()
		{
			// Задача1==========================================
			// Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
			// System.Console.WriteLine("Please, enter the number of rows for the array");
			// int row = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of columns for the array");
			// int column = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter min value: ");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter max value: ");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[,] array = CreateArray(row, column, min, max);
			// ShowArray(array);
			// int[,] result = SortFunction(array);
			// ShowArray(result);
			// Задача1==========================================
			// Задача2==========================================
			// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
			// System.Console.WriteLine("Please, enter the number of rows for the array");
			// int row = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of columns for the array");
			// int column = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter min value: ");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter max value: ");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[,] array = CreateArray(row, column, min, max);
			// ShowArray(array);
			// int[] result = FindSumm(array);
			// ShowLine(result);
			// Задача2==========================================
			// Задача3==========================================
			// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
			// System.Console.WriteLine("Please, enter the number of rows for 2 arrays");
			// int row = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of columns for 2 arrays");
			// int column = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter min value: ");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter max value: ");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[,] array1 = CreateArray(row, column, min, max);
			// int[,] array2 = CreateArray(row, column, min, max);
			// ShowArray(array1);
			// ShowArray(array2);
			// int[,] result = multiplication(array1, array2);
			// ShowArray(result);
			// Задача3==========================================
			// Задача4==========================================
			// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
			// Задача4==========================================
		}
		// Задача1==========================================
		// public static int[,] CreateArray(int rows, int columns, int min, int max)
		// {
		// 	int[,] array = new int[rows, columns];

		// 	for (int i = 0; i < rows; i++)
		// 	{
		// 		for (int j = 0; j < columns; j++)
		// 		{
		// 			array[i, j] = new Random().Next(min, max);
		// 		}
		// 	}
		// 	return array;
		// }
		// public static void ShowArray(int[,] array)
		// {
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			System.Console.Write(array[i, j] + " ");
		// 		}
		// 		System.Console.WriteLine();
		// 	}
		// 	System.Console.WriteLine();
		// }
		// public static int[,] SortFunction(int[,] array)
		// {
		// 	for (int n = 0; n < array.GetLength(0); n++)
		// 	{

		// 		for (int i = 0; i < array.GetLength(1); i++)
		// 		{
		// 			int max = i;

		// 			for (int j = i + 1; j < array.GetLength(1); j++)
		// 			{
		// 				if (array[n, max] < array[n, j])
		// 				{
		// 					int tempo = array[n, max];
		// 					array[n, max] = array[n, j];
		// 					array[n, j] = tempo;
		// 				}
		// 			}
		// 		}
		// 	}
		// 	return array;
		// }
		// Задача1==========================================
		// Задача2==========================================
		// public static int[,] CreateArray(int rows, int columns, int min, int max)
		// {
		// 	int[,] array = new int[rows, columns];

		// 	for (int i = 0; i < rows; i++)
		// 	{
		// 		for (int j = 0; j < columns; j++)
		// 		{
		// 			array[i, j] = new Random().Next(min, max);
		// 		}
		// 	}
		// 	return array;
		// }
		// public static void ShowArray(int[,] array)
		// {
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			System.Console.Write(array[i, j] + " ");
		// 		}
		// 		System.Console.WriteLine();
		// 	}
		// 	System.Console.WriteLine();
		// }
		// public static int[] FindSumm(int[,] array)
		// {
		// 	int[] newArr = new int[array.GetLength(0)];
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		int summ = 0;
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			summ += array[i, j];
		// 		}
		// 		System.Console.WriteLine($"The Summ of the line {i} = {summ}");
		// 		newArr[i] = summ;
		// 	}
		// 	return newArr;
		// }
		// public static void ShowLine(int[] res)
		// {
		// 	int min = res[0];
		// 	int line = 0;
		// 	for (int i = 0; i < res.GetLength(0); i++)
		// 	{
		// 		if (min > res[i]) min = res[i]; line = i;
		// 	}
		// 	System.Console.WriteLine($"The law summ is {min} on the line {line}");
		// }

		// Задача2==========================================
		// Задача3==========================================
		// public static int[,] CreateArray(int rows, int columns, int min, int max)
		// {
		// 	int[,] array = new int[rows, columns];

		// 	for (int i = 0; i < rows; i++)
		// 	{
		// 		for (int j = 0; j < columns; j++)
		// 		{
		// 			array[i, j] = new Random().Next(min, max);
		// 		}
		// 	}
		// 	return array;
		// }
		// public static void ShowArray(int[,] array)
		// {
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			System.Console.Write(array[i, j] + " ");
		// 		}
		// 		System.Console.WriteLine();
		// 	}
		// 	System.Console.WriteLine();
		// }
		// public static int[,] multiplication(int[,] arr1, int[,] arr2)
		// {
		// 	int[,] newArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
		// 	if (arr1.GetLength(1) == arr2.GetLength(0))
		// 	{
		// 		for (int i = 0; i < arr1.GetLength(0); i++)
		// 		{
		// 			for (int j = 0; j < arr2.GetLength(1); j++)
		// 			{
		// 				for (int k = 0; k < arr2.GetLength(0); k++)
		// 				{
		// 					newArr[i, j] += arr1[i, k] * arr2[k, j];
		// 				}
		// 			}
		// 		}
		// 	}
		// 	else System.Console.WriteLine("Sorry arrays should be square or the number of columns of the matrix A is equal to the number of rows of the matrix B");
		// 	return newArr;
		// }
		// Задача3==========================================
		// Задача4==========================================
	}
}