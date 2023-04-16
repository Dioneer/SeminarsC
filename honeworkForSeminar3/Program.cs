using System;
namespace homeworkForSemainar3
{
	class homeworkSemainar3
	{
		static void Main()
		{
			// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

			//===Задача 19 решена двумя способами v1. Здесь запуск==========================================================
			// System.Console.WriteLine("Hello! Let's find out if a number is a palindrome or not. Please, enter a number");
			// string inputNumber = Console.ReadLine();
			// checkInput(inputNumber);

			//===Задача решена двумя способами v2. Здесь запуск==========================================================
			// System.Console.WriteLine("Hello! Let's find out if a number is a palindrome or not. Please, enter a number");
			// string inputNumber = Console.ReadLine();
			// checkInput(inputNumber);
		}
		//===Задача 19 решена двумя способами v1=========================================================================
		// public static void checkInput(string receiveString)
		// {
		// 	if (double.TryParse(receiveString, out double receiveNumber))
		// 	{
		// 		bool result = checkNumber(receiveString);
		// 		string interp = "";
		// 		if (result) interp = "a palindrome";
		// 		else interp = "not a palindrome";
		// 		System.Console.WriteLine($"Your input value is {interp}");
		// 	}
		// 	else
		// 	{
		// 		System.Console.WriteLine("Your input value is not a number. If you want to continue press any key");
		// 		Console.ReadKey();
		// 	}
		// }
		// public static bool checkNumber(string receiveString)
		// {
		// 	char[] letters = receiveString.ToCharArray();
		// 	Array.Reverse(letters);
		// 	string recChar = String.Join("", letters);
		// 	if (receiveString == recChar)
		// 	{
		// 		return true;
		// 	}
		// 	return false;
		// }
		//===Задача 19 решена двумя способами v1=========================================================================
		//===Задача 19 решена двумя способами v2=========================================================================
		// public static void checkInput(string receiveString)
		// {
		// 	if (double.TryParse(receiveString, out double receiveNumber))
		// 	{
		// 		bool result = checkNumber(receiveNumber);
		// 		string interp = "";
		// 		if (result) interp = "a palindrome";
		// 		else interp = "not a palindrome";
		// 		System.Console.WriteLine($"Your input value is {interp}");
		// 	}
		// 	else
		// 	{
		// 		System.Console.WriteLine("Your input value is not a number. If you want to continue press any key");
		// 		Console.ReadKey();
		// 	}
		// }
		// public static bool checkNumber(double receiveNumber)
		// {
		// 	double result = 0;
		// 	double temp = receiveNumber;
		// 	while (temp > 0)
		// 	{
		// 		result = result * 10 + temp % 10;
		// 		temp = Math.Truncate(temp / 10);
		// 	}
		// 	if (receiveNumber == result)
		// 	{
		// 		return true;
		// 	}
		// 	return false;
		// }
		//===Задача 19 решена двумя способами v2=========================================================================
	}
}