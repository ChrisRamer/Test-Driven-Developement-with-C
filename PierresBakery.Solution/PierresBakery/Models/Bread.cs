namespace PierresBakery
{
	public class Bread
	{
		public int Amount { get; set; }
		public int Cost { get; set; }
		private int Price = 5;
		private bool useDiscount = false;

		public Bread(int count, bool useDiscount = true)
		{
			this.Amount = count;
			this.useDiscount = useDiscount;
		}

		public int GetCurrentCost()
		{
			int currCost = this.Amount * this.Price;

			// Discount
			if (useDiscount)
			{
				for (int i = 1; i < this.Amount + 1; i++)
				{
					if (i % 2 == 0) currCost -= 5;
				}
			}

			Cost = currCost;
			return currCost;
		}
	}
}