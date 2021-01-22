using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakeryTests
{
	[TestClass]
	public class BakeryTests
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

		[TestMethod]
		public void GetCurrentAmount_GetOrderAmountForPastry_Int()
		{
			Pastry pastry = new Pastry(7);
			 
			int result = pastry.GetCurrentAmount();

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