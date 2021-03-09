namespace PierresBakery
{
	public class Bread
	{
		public int Amount { get; set; }
		public int Cost { get; set; }
		private int Price = 5;

		public Bread(int count)
		{
			this.Amount = count;
		}

		public int GetCurrentCost()
		{
			int currCost = this.Amount * this.Price;
			for (int i = 1; i < this.Amount + 1; i++)
			{
				if (i % 2 == 0) currCost -= 5;
			}

			Cost = currCost;
			return currCost;
		}
	}
}