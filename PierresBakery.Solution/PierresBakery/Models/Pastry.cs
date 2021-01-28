using System;
using System.Collections.Generic;

namespace PierresBakery
{
	public class Pastry
	{
		public int Amount { get; set; }
		private int Price= 2;

		public Pastry(int count)
		{
			this.Amount = count;
		}

		public int GetCurrentCost()
		{
			int currCost = this.Amount * this.Price;
			for (int i = 1; i < this.Amount + 1; i++)
			{
				if (i % 3 == 0) currCost--;
			}

			return currCost;
		}
	}
}