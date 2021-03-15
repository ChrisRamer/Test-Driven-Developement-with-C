using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakeryTests
{
	[TestClass]
	public class BreadTests
	{
		[TestMethod]
		public void BreadConstructor_CreateInstanceOfBread_Bread()
		{
			Bread newBread = new Bread(5);
			Assert.AreEqual(typeof(Bread), newBread.GetType());
		}

		[TestMethod]
		public void GetCurrentAmount_GetOrderAmountForBread_Int()
		{
			Bread bread = new Bread(3);

			int result = bread.Amount;

			Assert.AreEqual(result, 3);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostForBread_Int()
		{
			Bread bread = new Bread(6);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 15);
		}

		[TestMethod]
		public void GetCurrentCostWithoutDiscount_GetOrderCostForBread()
		{
			Bread bread = new Bread(2, false);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 10);
		}
	}
}