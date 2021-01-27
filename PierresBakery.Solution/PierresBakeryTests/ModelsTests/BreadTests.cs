using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakeryTests
{
	[TestClass]
	public class BreadTests
	{
		[TestMethod]
		public void GetCurrentAmount_GetOrderAmountForBread_Int()
		{
			Bread bread = new Bread(3);

			int result = bread.GetCurrentAmount();

			Assert.AreEqual(result, 4);
		}

		[TestMethod]
		public void GetCurrentCost_GetOrderCostForBread_Int()
		{
			Bread bread = new Bread(3);

			int result = bread.GetCurrentCost();

			Assert.AreEqual(result, 15);
		}
	}
}