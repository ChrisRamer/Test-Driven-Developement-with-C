using System;
using System.Collections.Generic;

namespace PierresBakery
{
	public class Bread
	{
		public int Amount {get; set;}
		private int price = 5;

		public Bread(int count)
		{
			this.Amount = count;
		}

		public int GetCurrentCost()
		{
			return this.Amount * this.price;
		}

		public int GetCurrentAmount()
		{
			int count = this.Amount;
			for (int i = 1; i < this.Amount + 1; i++)
			{
				if (i % 2 == 0) count++;
			}

			return count;
		}
	}
}