public class Program
{
	public static void Main()
	{
		// Erste Methode mit out-Parameter
		//int x;
		//string ausgabeT = "Bitte eine Zahl eingeben: ";
		//bool hatFunktioniert = ZahlEinlesen(ausgabeT, out x);
		//Console.WriteLine($"Die eingegebene Zahl ist: {x} und der Text ist \n{ausgabeT}");

		//bool ZahlEinlesen( string ausgabeText, out int zahl)
		//{
		//	Console.WriteLine(ausgabeText);
		//	bool erfolg = int.TryParse(Console.ReadLine(), out zahl);
		//	return erfolg;
		//}

		// Überladene Methoden
		Math.Round(2.555);
		Math.Round(2.555, 2);

		bool erfolg = ZahlEinlesen(out int zahl1);
		erfolg = ZahlEinlesen(out zahl1, "Bitte Zahl eingeben");

		// Automatische Arrays
		int[] zahlen = new int[]{ 1, 2, 3, 4, 5 };
		int ergebnis = SummeBerechnen(zahlen);

		// mit params braucht man kein Array zu erstellen und kann die Werte direkt übergeben
		int ergebnis2 = SummeBerechnen(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

	}
	// Überladene Methode
	static private bool ZahlEinlesen(out int zahl)
	{
		Console.WriteLine("Zahl eingeben.");
		bool erfolg = int.TryParse(Console.ReadLine(), out zahl);
		return erfolg;
	}

	static private bool ZahlEinlesen(out int zahl, string ausgabeText)
	{
		Console.WriteLine(ausgabeText);
		bool erfolg = int.TryParse(Console.ReadLine(), out zahl);
		return erfolg;
	}


	// Automatische Arrays
	static private int SummeBerechnen(params int[] zahlen)
	{
		return zahlen.Sum();
	}
}


