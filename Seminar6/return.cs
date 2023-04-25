using System;
namespace Seminar6
{
	class Return
	{
		private int[] array;

		public int[] CreateArr(int len)
		{
			int[] arr = new int[len];
			for (int i = 0; i < len; i++)
			{
				int randNumber = new Random().Next(1, 256);
				arr[i] = randNumber;
			}
			return arr;
		}
		public void CopyArr(int[] arr)
		{
			this.array = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				this.array[i] = arr[i];
			}
			show(array);
		}
		public void show(int[] arr)
		{
			foreach (int item in arr)
			{
				System.Console.WriteLine($"Elem:{item}");
			}
		}
	}
}