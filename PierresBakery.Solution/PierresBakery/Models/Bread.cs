using System;
using System.Collections.Generic;

namespace PierresBakery
{
	public class Bread
	{
		public int amount {get; set;}
		private int price = 5;

		public Bread(int count)
		{
			this.amount = count;
		}

		public int GetCurrentCost()
		{
			return this.amount * this.price;
		}

		public int GetCurrentAmount()
		{
			int count = this.amount;
			for (int i = 1; i < this.amount + 1; i++)
			{
				if (i % 2 == 0) count++;
			}

			return count;
		}
	}
}