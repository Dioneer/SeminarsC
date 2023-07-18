using System;
namespace Seminar3
{
	class SeminarTask
	{
		static void Main()
		{
			// Напишите программу, которая принимает на вход координаты точки (X и Y), и выдаёт номер четверти плоскости, в которой находится эта точка.	
			// Console.WriteLine("Please, enter coord x");
			// double coordX = Convert.ToDouble(Console.ReadLine());
			// Console.WriteLine("Please, enter coord y");
			// double coordY = Convert.ToDouble(Console.ReadLine());
			// double returnRes = returnCoord(coordX, coordY);
			// Console.WriteLine($"Ваша координатная плоскость {returnRes}");

			// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
			// Console.WriteLine("Ведиие число");
			// int num = Convert.ToInt32(Console.ReadLine());
			// TablKvad(num);

			// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
			// Console.Write("Введите значение x1 - ");
			// int x1 = Convert.ToInt32(Console.ReadLine());

			// Console.Write("Введите значение y1 - ");
			// int y1 = Convert.ToInt32(Console.ReadLine());

			// Console.Write("Введите значение x2 - ");
			// int x2 = Convert.ToInt32(Console.ReadLine());

			// Console.Write("Введите значение y2 - ");
			// int y2 = Convert.ToInt32(Console.ReadLine());

			// Console.Write($"Расстояние между точками 1 и 2  составляет  - {Gipot(x1, y1, x2, y2)}");
		}
		// =====================================================
		// public static int returnCoord(double x, double y)
		// {
		// 	if (x > 0 && y > 0) return 1;
		// 	else if (x < 0 && y > 0) return 2;
		// 	else if (x < 0 && y < 0) return 3;
		// 	else return 4;
		// }
		// =====================================================
		// public static void TablKvad(int N)
		// {
		// 	int count = 1;
		// 	while (count <= N)
		// 	{
		// 		Console.WriteLine($"Квадрат {count} составляет {count * count}");
		// 		count++;
		// 	}
		// }
		// =====================================================
		// public static double Gipot(double x1, double y1, double x2, double y2)
		// {
		// 	double distX = x2 - x1;
		// 	double distY = y2 - y1;
		// 	double result = Math.Sqrt(distX * distX + distY * distY);
		// 	return result;
		// }
	}
}