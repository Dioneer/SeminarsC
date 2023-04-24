using System;
namespace Homework5
{
	class PlusCounter
	{
		private int[] array;
		private int length;

		public int[] randomArray(int length)
		{
			this.length = length;
			this.array = new int[this.length];
			for (byte i = 0; i < this.length; i++)
			{
				this.array[i] = new Random().Next(100, 1000);
			}
			return this.array;
		}

		public void showArr(int[] arr)
		{
			foreach (int item in arr)
			{
				System.Console.WriteLine($"Element: {item}");
			}
		}
		public int counter(int[] array)
		{
			int count = 0;
			foreach (int item in array)
			{
				if (item % 2 == 0) count++;
			}
			return count;
		}
	}
}