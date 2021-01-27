using System;
using System.Text.RegularExpressions;

namespace PierresBakery
{
	public class Program
	{
		private static int breadCount = 0;
		private static int breadCost = 0;
		private static int pastryCount = 0;
		private static int pastryCost = 0;

		public static void Main()
		{
			Console.WriteLine("-------------------------");
			Console.WriteLine("Welcome to Pierre's Bakery! Would you like to order some of our fabulous bread or our award winning pastries?");
			Console.WriteLine("Bread is $5 per loaf; buy 2 get 1 free! Pastries are $2 or 3 for $5!");
			Console.WriteLine("Respoond with 'bread' or 'b' for bread, or 'pastry' or 'p' for pastry");
			string userChoice = EvaluateUserChoice(Console.ReadLine());
			Console.WriteLine("-------------------------");
			if (string.IsNullOrEmpty(userChoice))
			{
				Console.WriteLine("ERROR: Please specify 'bread' or 'b' for bread, or 'pastry' or 'p' for pastry");
				Main();
				return;
			}

			if (userChoice == "bread")
			{
				OrderBread();
			}
			else
			{
				Console.WriteLine("How many pastries would you like?");
				Console.WriteLine("Pastries are $2 or 3 for $5!");

				OrderPastry();
			}
		}

		static void OrderBread()
		{
			Console.WriteLine("How much bread would you like?");
			Console.WriteLine("Bread is $5 per loaf; buy 2 get 1 free!");
			string amount = Console.ReadLine();

			if (int.TryParse(amount, out int count))
			{
				Console.WriteLine("-------------------------");
				Bread bread = new Bread(count);
				breadCost = bread.GetCurrentCost();
				Console.WriteLine("You would like " + count + " loaves of bread, costing $" + breadCost + "?");
				Console.WriteLine("Respond with 'yes' or 'y' to confirm or anything else to reset order.");

				string userResponse1 = Console.ReadLine();
				if (userResponse1 == "yes" || userResponse1 == "y")
				{
					breadCount = bread.GetCurrentAmount();
					GiveOrderSummary();
					Console.WriteLine("-------------------------");
					Console.WriteLine("Would you like to order some pastries?");
					Console.WriteLine("Respond with 'yes' or 'y' to order pastries or anything else to confirm the current order.");

					string userResponse2 = Console.ReadLine();
					if (userResponse2 == "yes" || userResponse2 == "y")
					{
						OrderPastry();
					}
					else
					{
						ConfirmOrder();
					}
				}
				else
				{
					Main();
					breadCount = 0;
					pastryCount = 0;
				}
			}
		}

		static void OrderPastry()
		{
			Console.WriteLine("How many pastries would you like?");
			Console.WriteLine("1 pastry is $2; buy 3 for $5!");
			string amount = Console.ReadLine();

			if (int.TryParse(amount, out int count))
			{
				Console.WriteLine("-------------------------");
				Pastry pastry = new Pastry(count);
				pastryCost = pastry.GetCurrentCost();
				Console.WriteLine("You would like " + count + " pastries, costing $" + pastryCost + "?");
				Console.WriteLine("Respond with 'yes' or 'y' to confirm or anything else to reset order.");

				string userResponse1 = Console.ReadLine();
				if (userResponse1 == "yes" || userResponse1 == "y")
				{
					pastryCount = pastry.Amount;
					GiveOrderSummary();
					Console.WriteLine("-------------------------");
					Console.WriteLine("Would you like to order some bread?");
					Console.WriteLine("Respond with 'yes' or 'y' to order pastries or anything else to confirm the current order.");

					string userResponse2 = Console.ReadLine();
					if (userResponse2 == "yes" || userResponse2 == "y")
					{
						OrderBread();
					}
					else
					{
						ConfirmOrder();
					}
				}
				else
				{
					Main();
					breadCount = 0;
					pastryCount = 0;
				}
			}
		}

		static void GiveOrderSummary()
		{
			Console.WriteLine("-------------------------");
			Console.WriteLine("Your order:");
			if (breadCount > 0) Console.WriteLine("Bread x" + breadCount + " for $" + breadCost);
			if (pastryCount > 0) Console.WriteLine("Pastry x" + pastryCount + " for $" + pastryCost);
			Console.WriteLine("Total: $" + (breadCost + pastryCost));
		}

		static void ConfirmOrder()
		{
			Console.WriteLine("-------------------------");
			GiveOrderSummary();
			Console.WriteLine("Thank you for your purchase! Your total is: $" + (breadCost + pastryCost));
		}

		static string EvaluateUserChoice(string choice)
		{
			if (choice == "bread" || choice == "b") return "bread";
			if (choice == "pastry" || choice == "p") return "pastry";

			return string.Empty;
		}
	}
}