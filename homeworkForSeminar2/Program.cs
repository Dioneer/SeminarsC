using System;

namespace Homewor2
{
	class ProgramHomework
	{
		static void Main()
		{
			// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
			//======Запуск задачи 10 ===================
			// requestNumber();

			// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
			//======Запуск задачи 13 варинт1===================
			// requestNumber();
			//======Запуск задачи 13 варинт2===================
			// parseString();

		}
		//======Задача 10 ==============================================================
		// public static void requestNumber()
		// {
		// 	Console.Clear();
		// 	Console.WriteLine("Hello! Please, enter a three-digit number to get the second digit");
		// 	string inputForCheck = Console.ReadLine();
		// 	if (short.TryParse(inputForCheck, out short inputNumber))
		// 	{
		// 		short checkNumber = Convert.ToInt16(inputNumber);
		// 		if (checkNumber > 99 && checkNumber < 1000 || checkNumber < -99 && checkNumber > -1000)
		// 		{
		// 			dissectionNumber(checkNumber);
		// 		}
		// 		else
		// 		{
		// 			string showResult = "Your number is bigger or smaller then three-digi";
		// 			showNumber(showResult);
		// 		}

		// 	}
		// 	else
		// 	{
		// 		string showResult = "Sorry, wrong type of input";
		// 		showNumber(showResult);
		// 	}
		// }
		// public static void dissectionNumber(short numberForDissection)
		// {
		// 	short dozen = Convert.ToInt16(numberForDissection / 10);
		// 	short result = Convert.ToInt16(dozen % 10);


		// 	string showResult = Convert.ToString(result);
		// 	showNumber(showResult);
		// }
		// public static void showNumber(string showResult)
		// {
		// 	Console.WriteLine(showResult);
		// }
		//======Задача 10 ==============================================================
		//======Задача 13 вариант1======================================================
		// public static void requestNumber()
		// {
		// 	Console.Clear();
		// 	Console.WriteLine("Hello! Please, enter an integer number to get the third digit or may be it's absent today");
		// 	string inputForCheck = Console.ReadLine();
		// 	if (int.TryParse(inputForCheck, out int inputNumber))
		// 	{
		// 		int checkNumber = Convert.ToInt32(inputNumber);
		// 		if (checkNumber > -100 && checkNumber < 100)
		// 		{
		// 			string showResult = "Third digit is absent today";
		// 			showNumber(showResult);
		// 		}
		// 		else
		// 		{
		// 			dissectionNumber(checkNumber);
		// 		}

		// 	}
		// 	else
		// 	{
		// 		string showResult = "Sorry, wrong type of input";
		// 		showNumber(showResult);
		// 	}
		// }
		// public static void dissectionNumber(int numberForDissection)
		// {
		// 	int hundred = 0;
		// 	int i = 0;
		// 	while (numberForDissection > 1000 || numberForDissection < -1000)
		// 	{
		// 		numberForDissection = numberForDissection / 10;
		// 		hundred = numberForDissection;
		// 		i++;
		// 	}

		// 	int result = hundred % 10;

		// 	string showResult = Convert.ToString(result);
		// 	showNumber(showResult);
		// }
		// public static void showNumber(string showResult)
		// {
		// 	Console.WriteLine(showResult);
		// }
		//======Задача 13 вариант1======================================================
		//======Задача 13 вариант2======================================================
		// public static void parseString()
		// {
		// 	Console.Clear();
		// 	Console.WriteLine("Hello! Please, enter an integer number to get the third digit or may be it's absent today");
		// 	string inputForCheck = Console.ReadLine();
		// 	if (int.TryParse(inputForCheck, out int inputNumber))
		// 	{
		// 		int checkNumber = Convert.ToInt32(inputNumber);
		// 		if (checkNumber > -100 && checkNumber < 100)
		// 		{
		// 			string showResult = "Third digit is absent today";
		// 			showNumber(showResult);
		// 		}
		// 		else
		// 		{
		// 			dissectionNumber(inputForCheck);
		// 		}

		// 	}
		// 	else
		// 	{
		// 		string showResult = "Sorry, wrong type of input";
		// 		showNumber(showResult);
		// 	}
		// }
		// public static void dissectionNumber(string showResult)
		// {
		// 	if (showResult > 0) Console.WriteLine(showResult.Substring(2, 1));
		// 	else Console.WriteLine(showResult.Substring(3, 1));
		// }
		// public static void showNumber(string showResult)
		// {
		// 	Console.WriteLine(showResult);
		// }
		//======Задача 13 вариант2======================================================
	}
}

