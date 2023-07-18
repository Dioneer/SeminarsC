using System;
namespace homework4
{
	class Cycle
	{
		private byte[] array;

		public byte[] setArray()
		{
			this.array = new byte[8];
			for (byte i = 0; i < array.Length; i++)
			{
				byte randNumber = Convert.ToByte(new Random().Next(1, 256));
				this.array[i] = randNumber;
			}
			return this.array;
		}
		public void showArr()
		{
			setArray();
			foreach (byte el in this.array)
			{
				System.Console.WriteLine($"Elements are: {el}");
			}
		}
	}
}