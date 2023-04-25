using System;
namespace Seminar6
{
	class Programm6
	{

		static void Main()
		{
			// ==================1============
			// int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
			// reverse(arr);
			// ==================1============
			// ==================2============
			// System.Console.WriteLine("Enter number: ");
			// int num1 = Convert.ToInt32(Console.ReadLine());
			// int num2 = Convert.ToInt32(Console.ReadLine());
			// int num3 = Convert.ToInt32(Console.ReadLine());
			// bool result = CheckTry(num1, num2, num3);
			// System.Console.WriteLine(result);
			// ==================2============
			// ==================3============
			// System.Console.WriteLine("Enter langth: ");
			// int num1 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter num2: ");
			// int num2 = Convert.ToInt32(Console.ReadLine());
			// System.Console.WriteLine("Enter num3: ");
			// int num3 = Convert.ToInt32(Console.ReadLine());
			// int[] result = Febonachy(num1, num2, num3);
			// Febonachy(result);
			// ==================3============
			System.Console.WriteLine("Enter length: ");
			Return result = new Return();
			int num1 = Convert.ToInt32(Console.ReadLine());
			int[] array = result.CreateArr(num1);
			result.CopyArr(array);
		}
		// ==================1============
		// public static void reverse(int[] arr)
		// {
		// 	for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
		// 	{
		// 		int temp = arr[i];
		// 		arr[i] = arr[j];
		// 		arr[j] = temp;
		// 	}
		// 	for (int i = 0; i < arr.Length; i++)
		// 	{
		// 		System.Console.WriteLine(arr[i]);
		// 	}
		// }
		// 1 Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
		// public static void reverse(int[] arr)
		// {
		// 	for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
		// 	{
		// 		int temp = arr[i];
		// 		arr[i] = arr[j];
		// 		arr[j] = temp;
		// 	}
		// 	for (int i = 0; i < arr.Length; i++)
		// 	{
		// 		System.Console.WriteLine(arr[i]);
		// 	}
		// }
		// ==================1============
		// ==================2============
		// public static bool CheckTry(int num1, int num2, int num3)
		// {
		// 	if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true;
		// 	return false;
		// }
		// ==================2============
		// ==================3============
		// public static int[] Febonachy(int len, int num1, int num2)
		// {
		// 	int[] array = new int[len];
		// 	array[0] = num1;
		// 	array[1] = num2;
		// 	for (int i = 2; i < array.Length; i++)
		// 	{
		// 		array[i] = array[i - 1] + array[i - 2];
		// 	}

		// 	return array;
		// }

		// public static void show(int[] arr)
		// {
		// 	foreach (int item in arr)
		// 	{
		// 		System.Console.WriteLine(item);
		// 	}
		// }
		// ==================3============
	}
}