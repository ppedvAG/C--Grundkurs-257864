public class Program
{
	public static void Main(string[] args)
	{
		int[] gewinnzahlen = new int[] { 42, 69, 67, 13, 7 };

		int getippteZahl;
		Console.WriteLine("gib eine Zahl zwichen 0 und 100 ein.");
		getippteZahl = int.Parse(Console.ReadLine());

		if(gewinnzahlen.Contains(getippteZahl))
		{
			Console.WriteLine("Du hast eine richtige Zahl getippt");
		} else
		{
			Console.WriteLine("Das war falsch, try again :(");
		}

	}
}