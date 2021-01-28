using System;
using System.Text.RegularExpressions;

namespace PierresBakery
{
	public class Program
	{
		public static void Main()
		{
			// Intro
			Console.WriteLine("-------------------------");
			Console.WriteLine("Welcome to Pierre's Bakery! Would you like to order some of our fabulous bread or our award winning pastries?");
			Console.WriteLine("Bread is $5 per loaf; buy 2 get 1 free! Pastries are $2 or 3 for $5!");
			Console.WriteLine("Respoond with 'bread' or 'b' for bread, or 'pastry' or 'p' for pastry");
			Console.WriteLine("-------------------------");
			Bread bread = new Bread(0);
			Pastry pastry = new Pastry(0);
			int count = 0;
			int breadCost = 0;

			// Order bread
			Console.WriteLine("How much bread would you like?");

			if (int.TryParse(Console.ReadLine(), out count))
			{
				bread = new Bread(count);
				Console.WriteLine("-------------------------");
				Console.WriteLine("You chose " + count + " loaves of bread, costing $" + bread.GetCurrentCost());
				Console.WriteLine("-------------------------");
			}
			else
			{
				Console.WriteLine("ERROR: Please specify an amount (number) of bread to get.");
				Main();
				return;
			}

			// Order pastries
			Console.WriteLine("How many pastries would you like?");

			if (int.TryParse(Console.ReadLine(), out count))
			{
				pastry = new Pastry(count);
				Console.WriteLine("-------------------------");
				Console.WriteLine("You chose " + count + " pastries, costing $" + pastry.GetCurrentCost());
				Console.WriteLine("-------------------------");
			}
			else
			{
				Console.WriteLine("ERROR: Please specify an amount (number) of bread to get.");
				Main();
				return;
			}

			breadCost = bread.GetCurrentCost();

			// Confirm bonus(es)
			if (bread.GetBonus() > 0)
			{
				Console.WriteLine("Your order can include " + (bread.GetBonus()) + " free loaves of bread");
				Console.WriteLine("How many of these free loaves would you like to add to your order?");

				if (int.TryParse(Console.ReadLine(), out count))
				{
					if (count <= bread.GetBonus())
					{
						bread.Amount += count;
					}
				}
			}

			// Order summary
			Console.WriteLine("Your order:");
			if (bread.Amount > 0) Console.WriteLine("Bread x" + bread.Amount + " for $" + breadCost);
			if (pastry.Amount > 0) Console.WriteLine("Pastry x" + pastry.Amount + " for $" + pastry.GetCurrentCost());
			Console.WriteLine("Total: $" + (breadCost + pastry.GetCurrentCost()));

			// Confirm order
			Console.WriteLine("-------------------------");
			Console.WriteLine("Would you like to confirm this order?");
			Console.WriteLine("Type 'yes' or 'y' to confirm. Anything else to reset it.");
			string confirmation = Console.ReadLine().ToLower();

			if (confirmation == "yes" || confirmation == "y")
			{
				int randYears = new Random().Next(10, 999);
				Console.WriteLine("-------------------------");
				Console.WriteLine("Thank you for your order! It will be delivered fresh to your door in just under " + randYears + " years!");
			}
			// Reset order
			else
			{
				Console.WriteLine("-------------------------");
				Console.WriteLine("Your order has been reset.");
				Main();
			}
		}
	}
}