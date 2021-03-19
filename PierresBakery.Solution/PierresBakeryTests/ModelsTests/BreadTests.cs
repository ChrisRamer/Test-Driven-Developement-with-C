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
		public void GetCurrentCost_GetOrderCostFor6Bread_Int()
		{
			Bread bread = new Bread(6);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 20);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostWithoutDiscountForBread_Int()
		{
			Bread bread = new Bread(4, false);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 20);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostFor92Bread_Int()
		{
			Bread bread = new Bread(92);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 310);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostFor49Bread_Int()
		{
			Bread bread = new Bread(49);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 165);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostFor787Bread_Int()
		{
			Bread bread = new Bread(787);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 2625);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostWithoutDiscountFor787Bread_Int()
		{
			Bread bread = new Bread(787, false);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 3935);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderDiscountFor787Bread_Int()
		{
			Bread bread = new Bread(787, false);
			int cost = bread.GetCurrentCost();
			Bread bread2 = new Bread(787);
			int discountedCost = bread2.GetCurrentCost();

			int result = cost - discountedCost;

			Assert.AreEqual(result, 1310);
		}
	}
}