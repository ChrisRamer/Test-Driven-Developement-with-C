using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakeryTests
{
	[TestClass]
	public class PastryTests
	{
		[TestMethod]
		public void PastryConstructor_CreateInstanceOfPastry_Pastry()
		{
			Pastry newPastry = new Pastry(5);
			Assert.AreEqual(typeof(Pastry), newPastry.GetType());
		}

		[TestMethod]
		public void GetCurrentAmount_GetOrderAmountForPastry_Int()
		{
			Pastry pastry = new Pastry(7);

			int result = pastry.Amount;

			Assert.AreEqual(result, 7);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostForPastry_Int()
		{
			Pastry pastry = new Pastry(2);

			int result = pastry.GetCurrentCost();

			Assert.AreEqual(result, 4);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostMinusDiscountForPastry_Int()
		{
			Pastry pastry = new Pastry(3);

			int result = pastry.GetCurrentCost();

			Assert.AreEqual(result, 5);
		}
	}
}