using System;
using System.Collections.Generic;

namespace PierresBakery
{
	public class Pastry
	{
		public int amount { get; set; }
		private int price = 2;

		public Pastry(int count)
		{
			this.amount = count;
		}

		public int GetCurrentCost()
		{
			int currCost = this.amount * this.price;
			for (int i = 0; i < this.amount; i++)
			{
				if (i > 0 && i % 3 == 0) currCost--;
			}

			return currCost;
		}

		public int GetCurrentAmount()
		{
			return this.amount;
		}
	}
}