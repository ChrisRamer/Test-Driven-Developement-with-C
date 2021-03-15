namespace PierresBakery
{
	public class Pastry
	{
		public int Amount { get; set; }
		public int Cost { get; set; }
		private int Price= 2;
		private bool UseDiscount { get; set; }

		public Pastry(int count, bool useDiscount = true)
		{
			this.Amount = count;
			this.UseDiscount = useDiscount;
		}

		public int GetCurrentCost()
		{
			int currCost = this.Amount * this.Price;

			if (UseDiscount)
			{
				for (int i = 1; i < this.Amount + 1; i++)
				{
					if (i % 3 == 0) currCost--;
				}
			}

			Cost = currCost;
			return currCost;
		}
	}
}