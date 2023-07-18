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

			// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
			//===Задача 21. Здесь запуск==================================================================================
			// System.Console.WriteLine("Let's find out the distance between two points in 3D space.");
			// System.Console.WriteLine("Please input first coord X1");
			// double Ax = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please input first coord Y1");
			// double Ay = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please input first coord Z1");
			// double Az = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please input first coord X2");
			// double Bx = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please input first coord Y2");
			// double By = Convert.ToDouble(Console.ReadLine());
			// System.Console.WriteLine("Please input first coord Z2");
			// double Bz = Convert.ToDouble(Console.ReadLine());
			// double result = findDist(Ax, Ay, Az, Bx, By, Bz);
			// System.Console.WriteLine($"The distance is {result}");

			// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
			//===Задача 23. Здесь запуск==================================================================================
			// System.Console.WriteLine("Let's find out a table of cubes from 1 till your number, please input integer: ");
			// double inputNumber = Convert.ToDouble(Console.ReadLine());
			// findCubic(inputNumber);
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
		//===Задача 21===================================================================================================
		// public static double findDist(double Ax, double Ay, double Az, double Bx, double By, double Bz)
		// {
		// 	double dist = 0;
		// 	double square = ((Ax - Bx) * (Ax - Bx)) + ((Ay - By) * (Ay - By)) + ((Az - Bz) * (Az - Bz));
		// 	dist = Math.Sqrt(square);
		// 	return dist;
		// }
		//===Задача 21===================================================================================================
		//===Задача 23===================================================================================================
		// public static void findCubic(double Cubic)
		// {
		// 	if (Cubic > 0)
		// 	{
		// 		for (byte i = 0; Cubic > 0; i++)
		// 		{
		// 			double result = Convert.ToDouble(Cubic * Cubic * Cubic);
		// 			System.Console.WriteLine($"Cubic of {Cubic} is {result}");
		// 			Cubic--;
		// 		}
		// 	}
		// 	else
		// 	{
		// 		for (double i = Cubic; Cubic < 0;)
		// 		{
		// 			double result = Convert.ToDouble(Cubic * Cubic * Cubic);
		// 			System.Console.WriteLine($"Cubic of {Cubic} is {result}");
		// 			Cubic++;
		// 		}
		// 	}
		// }
		//===Задача 23===================================================================================================
	}
}