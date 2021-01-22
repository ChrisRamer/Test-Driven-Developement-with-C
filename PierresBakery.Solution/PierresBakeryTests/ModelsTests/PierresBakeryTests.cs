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
		public void GetCurrentOrder_GetOrderItems_List()
		{
			Bread bread = new Bread();
			bread.MakeOrder(3);
			Pastry pastry = new Pastry();
			pastry.MakeOrder(2);

			string result = bread.GetCurrentOrder().items;

			Assert.AreEqual(result, "bread x3, pastry x2");
		}

		[TestMethod]
		public void GetCurrentOrder_GetOrderCost_Int()
		{
			Bread bread = new Bread();
			bread.MakeOrder(3);
			Pastry pastry = new Pastry();
			pastry.MakeOrder(2);

			int result = bread.GetCurrentOrder().cost;

			Assert.AreEqual(result, 19);
		}
	}
}