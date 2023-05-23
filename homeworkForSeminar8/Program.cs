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
			// Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
			// System.Console.WriteLine("Please, enter the number of rows for 1 arrays");
			// int row1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of columns for 1 arrays");
			// int column1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of rows for 2 arrays");
			// int row2 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of columns for 2 arrays");
			// int column2 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter min value: ");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter max value: ");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[,] array1 = CreateArray(row1, column1, min, max);
			// int[,] array2 = CreateArray(row2, column2, min, max);
			// ShowArray(array1);
			// ShowArray(array2);
			// int[,] result = multiplication(array1, array2);
			// ShowArray(result);
			// Задача3==========================================
			// Задача4==========================================
			// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
			// System.Console.WriteLine("Please, enter the number of rows for array");
			// int row = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of columns for array");
			// int column = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Please, enter the number of zZone:");
			// int zZone = Convert.ToInt32(Console.ReadLine());
			// int[,,] array = CreateArray(row, column, zZone);
			// ShowArray(array);
			// Задача4==========================================
			// Задача5==========================================
			// Напишите программу, которая заполнит спирально массив 4 на 4. 
			// Задача5==========================================
			System.Console.WriteLine("Please, enter the number of rows for the array");
			int row = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("Please, enter the number of columns for the array");
			int column = Convert.ToInt32(Console.ReadLine());
			int[,] array = CreateArray(row, column);
			ShowArray(array);
			// Задача5==========================================
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
		// 	else { System.Console.WriteLine("Sorry arrays should be square or the number of columns of the matrix A is equal to the number of rows of the matrix B"); }
		// 	return newArr;
		// }
		// Задача3==========================================
		// Задача4==========================================
		// public static int[,,] CreateArray(int rows, int columns, int zZone)
		// {
		// 	int length = rows * columns * zZone;
		// 	int resultCoof = 0;
		// 	bool flag = false;
		// 	int[,,] array = new int[rows, columns, zZone];
		// 	int[] arrForCheckReapit = new int[length];

		// 	// формирую простой массив уникальных значений. По ходу, вся сложность в этом. Ушло 3 часа, что б догадаться и вспомнить про do while
		// 	for (int i = 0; i < length; i++)
		// 	{
		// 		do
		// 		{
		// 			arrForCheckReapit[i] = new Random().Next(10, 100);
		// 			flag = true;

		// 			for (int j = 0; j < i; j++)
		// 				if (arrForCheckReapit[i] == arrForCheckReapit[j])
		// 				{
		// 					flag = false;
		// 					break;
		// 				}
		// 		} while (!flag);
		// 	}


		// 	// присваение значений простого массива в трехмерный
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			for (int z = 0; z < array.GetLength(2); z++)
		// 			{
		// 				array[i, j, z] = arrForCheckReapit[resultCoof];
		// 				resultCoof++;
		// 			}
		// 		}
		// 	}

		// 	return array;
		// }
		// public static void ShowArray(int[,,] array)
		// {
		// 	for (int i = 0; i < array.GetLength(0); i++)
		// 	{
		// 		for (int j = 0; j < array.GetLength(1); j++)
		// 		{
		// 			for (int z = 0; z < array.GetLength(2); z++)
		// 			{
		// 				System.Console.Write($"{array[i, j, z]}({i},{j},{z}) ");
		// 			}
		// 			System.Console.WriteLine();
		// 		}
		// 	}
		// 	System.Console.WriteLine();
		// }
		// Задача4==========================================
		// // Задача5==========================================
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
		// public static int[,] CreateArray(int rows, int columns)
		// {
		// 	int[,] array = new int[rows, columns];
		// 	int bottom = rows - 1;
		// 	int right = columns - 1;
		// 	int numbers = 1;
		// 	int top = 0;
		// 	int mainlength = columns / 2;
		// 	int index1 = 1;

		// 	while (mainlength > 0)
		// 	{
		// 		for (int j = top; j <= right; j++)
		// 		{
		// 			array[top, j] = numbers++;
		// 		}
		// 		for (int j = index1; j < rows - top; j++)
		// 		{
		// 			array[j, right] = numbers++;
		// 		}
		// 		for (int j = right - 1; j > top; j--)
		// 		{
		// 			array[bottom, j] = numbers++;
		// 		}
		// 		for (int j = bottom; j > top; j--)
		// 		{

		// 			array[j, top] = numbers++;
		// 		}
		// 		top++;
		// 		right--;
		// 		bottom--;
		// 		mainlength--;
		// 		index1++;
		// 	}
		// 	return array;
		// }
		// Задача5==========================================
	}
}