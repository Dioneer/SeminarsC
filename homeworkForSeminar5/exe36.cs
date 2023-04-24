using System;
namespace Homework5
{
	class SummOdd
	{
		private int length;
		private int[] array;

		public int[] randomArray(int length)
		{
			this.length = length;
			this.array = new int[this.length];
			for (int i = 0; i < this.length; i++)
			{
				this.array[i] = new Random().Next(-100, 101);
			}
			showArr(this.array);
			return this.array;
		}

		public void showArr(int[] array)
		{
			foreach (int item in array)
			{
				System.Console.WriteLine($"Elemet is: {item}");
			}
		}
		public int summFunc(int[] arr)
		{
			int summ = 0;
			int i = 1;
			while (i < arr.Length)
			{
				summ += arr[i];
				i += 2;
			}
			return summ;
		}
	}
}