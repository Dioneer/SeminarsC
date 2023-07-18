using System;

namespace Homework5
{
	class MinMax
	{
		private int length;
		private double[] array;

		public double[] randomArray(int length)
		{
			this.length = length;
			this.array = new double[this.length];
			for (byte i = 0; i < this.length; i++)
			{
				//2.3 - просто чтоб число не было ровным
				this.array[i] = Math.Round((new Random().Next(0, 101) / 2.3), 2);
			}
			showArr(this.array);
			return this.array;
		}

		public void showArr(double[] array)
		{
			foreach (double item in array)
			{
				System.Console.WriteLine($"Elemet is: {item}");
			}
		}

		public double[] minmax(double[] array)
		{
			double min = array[0];
			double max = array[0];
			for (byte i = 1; i < array.Length; i++)
			{
				if (max < array[i])
				{
					max = array[i];
				}
				if (min > array[i])
				{
					min = array[i];
				}
			}
			double[] mmArray = { min, max };
			return mmArray;
		}
		public double diff(double[] mmArray)
		{
			double result = mmArray[1] - mmArray[0];
			return result;
		}
	}
}