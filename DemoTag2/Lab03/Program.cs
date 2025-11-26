public class Program
{
	enum Rechenoperation
	{
		Addition = 1, Subtraktion, Multiplikation, Division
	}
	public static void Main(string[] args)
	{
		double zahl1, zahl2;
		Rechenoperation rechenoperation;
		bool allesOkay = false;

		do
		{
			zahl1 = ZahlEingabe("Gib eine Zahl ein: ");

			zahl2 = ZahlEingabe("Gib eine weitere Zahl ein: ");

			rechenoperation = RechenoperationEingabe();
			Berechne(zahl1, zahl2, rechenoperation);

			Console.WriteLine("Möchten Sie eine weitere Rechnung durchführen? (J/N)");
			allesOkay = Console.ReadKey().Key == ConsoleKey.J;
			Console.WriteLine();


		} while (allesOkay);

	}

	private static double Berechne(double zahl1, double zahl2, Rechenoperation operation)
	{
		switch (operation)
		{
			case Rechenoperation.Addition:
				Console.WriteLine("Ergebnis: " + (zahl1 + zahl2));
				return (zahl1 + zahl2);
			case Rechenoperation.Subtraktion:
				Console.WriteLine("Ergebnis: " + (zahl1 - zahl2));
				return zahl1 - zahl2;
			case Rechenoperation.Multiplikation:
				Console.WriteLine("Ergebnis: " + (zahl1 * zahl2));
				return zahl1 * zahl2;
			case Rechenoperation.Division:
				if (zahl2 == 0)
				{
					Console.WriteLine("Division dur 0 nicht erlaubt");
					return double.NaN;
				}
				else
				{
					Console.WriteLine("Ergebnis: " + (zahl1 / zahl2));
					return zahl1/ zahl2;
				}
		}
		return double.NaN;
	}

	private static double ZahlEingabe(string text)
	{
		bool allesOkay = false;
		double zahl;
		do
		{
			Console.Write(text);
			allesOkay = double.TryParse(Console.ReadLine(), out zahl);
			if (!allesOkay)
			{
				Console.WriteLine("Ungültige Eingabe.");
			}
		} while (!allesOkay);
		return zahl;
	}

	private static Rechenoperation RechenoperationEingabe()
	{
		// Auswahl der Rechenoperation (Ausgabe aller Möglichkeiten)
		Console.WriteLine("\n" +
			"Wähle eine Rechenoperation aus: ");
		for (int i = 1; i <= 4; i++)
		{
			Console.WriteLine($"{i}: {(Rechenoperation)i}");
		}
		int auswahl;
		do {
			auswahl = (int)ZahlEingabe("");
			if (!(auswahl >= 1 && auswahl <= 4))
			{
				Console.WriteLine("Ungültige Auswahl. Bitte eine Zahl zwischen 1 und 4 eingeben.");
			}
		} while (!(auswahl >= 1 && auswahl <= 4));

		return (Rechenoperation)auswahl;
	}

}
