public class pricingCalc
{
	public static void Main()
	{
		
		string length;
		string width;
		string price;
		
		System.Console.WriteLine("what is the length of your room?");
		length = System.Console.ReadLine();
		System.Console.WriteLine("what is the width of your room?");
		width = System.Console.ReadLine();
		System.Console.WriteLine("what is the price per square foot?");
		price = System.Console.ReadLine();

		int length2 = System.Convert.ToInt32(length);
		int width2 = System.Convert.ToInt32(width);
		int price2 = System.Convert.ToInt32(price);

		int area = length2 * width2;
		int cost = area * price2;

		System.Console.WriteLine("the area of the room is {0} and the cost is {1}.", area, cost);
	}
}