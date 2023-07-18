using System;
namespace homework4
{
	class Summ
	{
		private int Number;
		private int Result;

		public int getSumm(int Number)
		{
			this.Number = Number;
			int tempo = this.Number;
			this.Result = 0;
			while (tempo > 0)
			{
				Result += tempo % 10;
				tempo = tempo / 10;
			}
			return this.Result;
		}
	}
}