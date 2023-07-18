using System;
namespace homework4
{
	class Pow
	{
		private int number;
		private int power;
		public int returnRaisePow(int number, int power)
		{
			this.number = number;
			this.power = power;
			int result = this.number;
			for (byte i = 1; i < this.power; i++)
			{
				result *= this.number;
			}
			return result;
		}
	}
}