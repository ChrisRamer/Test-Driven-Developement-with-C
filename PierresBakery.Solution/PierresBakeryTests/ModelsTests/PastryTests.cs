using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakeryTests
{
	[TestClass]
	public class PastryTests
	{
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
			Pastry pastry = new Pastry(7);

			int result = pastry.GetCurrentCost();

			Assert.AreEqual(result, 12);
		}
	}
}