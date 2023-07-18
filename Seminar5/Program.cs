using System;
namespace Seminar5
{
	class Programm5
	{
		static void Main()
		{
			// task 1
			// int[] arr = CreateRandomArray(8, 1, 20);
			// showArray(arr);

			// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
			// System.Console.WriteLine("Enter size");
			// int n = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter min");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter max");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[] arr = CreateRandom(n, min, max);
			// ShowRevArr(arr);

			// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
			// System.Console.WriteLine("Enter size");
			// int n = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter min");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter max");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[] arr = CreateRandom(n, min, max);
			// System.Console.WriteLine("Enter find number");
			// ShowRevArr(arr);
			// int find = Convert.ToInt32(Console.ReadLine());
			// bool result = IsNumberExist(arr, find);
			// System.Console.WriteLine(result);

			// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
			// System.Console.WriteLine("Enter size");
			// int n = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter min");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter max");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[] arr = CreateRandom(n, min, max);
			// ShowRevArr(arr);
			// System.Console.WriteLine("Enter max");
			// int max2 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter min");
			// int min2 = Convert.ToInt32(Console.ReadLine());
			// int result = GetQElem(arr, min2, max2);
			// System.Console.WriteLine(result);

			// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
			// System.Console.WriteLine("Enter size");
			// int n = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter min");
			// int min = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter max");
			// int max = Convert.ToInt32(Console.ReadLine());
			// int[] arr = CreateRandom(n, min, max);
			// ShowRevArr(arr);
			// int[] result = Return(arr);
			// ShowRevArr(result);
		}
		// task 1
		// public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		// {
		// 	int[] array = new int[size];

		// 	for (int i = 0; i < size; i++)
		// 		array[i] = new Random().Next(minValue, maxValue + 1);

		// 	return array;
		// }
		// public static void showArray(int[] array)
		// {
		// 	foreach (int item in array)
		// 	{
		// 		System.Console.WriteLine($"Your elem is: {item}");
		// 	}
		// }

		// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
		// public static int[] CreateRandom(int size, int min, int max)
		// {
		// 	int[] arr = new int[size];
		// 	for (byte i = 0; i < size; i++)
		// 	{
		// 		arr[i] = new Random().Next(min, max + 1);
		// 	}

		// 	return arr;
		// }
		// public static void ShowRevArr(int[] arr)
		// {
		// 	foreach (int item in arr)
		// 	{
		// 		System.Console.WriteLine(item * -1);
		// 	}
		// }

		// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
		// public static int[] CreateRandom(int size, int min, int max)
		// {
		// 	int[] arr = new int[size];
		// 	for (byte i = 0; i < size; i++)
		// 	{
		// 		arr[i] = new Random().Next(min, max + 1);
		// 	}

		// 	return arr;
		// }
		// public static void ShowRevArr(int[] arr)
		// {
		// 	foreach (int item in arr)
		// 	{
		// 		System.Console.WriteLine(item);
		// 	}
		// }
		// public static bool IsNumberExist(int[] arr, int find)
		// {
		// 	foreach (int item in arr)
		// 	{
		// 		if (item == find) return true;
		// 	}
		// 	return false;
		// }
		// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
		// public static int[] CreateRandom(int size, int min, int max)
		// {
		// 	int[] arr = new int[size];
		// 	for (byte i = 0; i < size; i++)
		// 	{
		// 		arr[i] = new Random().Next(min, max + 1);
		// 	}

		// 	return arr;
		// }
		// public static void ShowRevArr(int[] arr)
		// {
		// 	foreach (int item in arr)
		// 	{
		// 		System.Console.WriteLine(item);
		// 	}
		// }
		// public static int GetQElem(int[] arr, int min, int max)
		// {
		// 	int result = 0;
		// 	for (int i = 0; i < arr.Length; i++)
		// 	{
		// 		if (arr[i] >= min && arr[i] <= max)
		// 		{
		// 			result++;

		// 		}
		// 	}
		// 	return result;
		// }

		// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
		// public static int[] CreateRandom(int size, int min, int max)
		// {
		// 	int[] arr = new int[size];
		// 	for (byte i = 0; i < size; i++)
		// 	{
		// 		arr[i] = new Random().Next(min, max + 1);
		// 	}

		// 	return arr;
		// }

		// public static int[] Return(int[] arr)
		// {

		// 	int count = 0;
		// 	int length = arr.Length / 2;
		// 	int[] arrOut = new int[length];
		// 	for (int i = 0; i < length; i++)
		// 	{
		// 		arrOut[i] = arr[i] * arr[arr.Length - 1 - i];
		// 	}
		// 	return arrOut;
		// }
		// public static void ShowRevArr(int[] arr)
		// {
		// 	foreach (int item in arr)
		// 	{
		// 		System.Console.WriteLine(item);
		// 	}
		// }
	}
}