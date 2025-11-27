using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerZumTesten
{
	public enum Rechenoperation
	{
		Addition = 1, Subtraktion, Multiplikation, Division
	}
	public static class Methoden
	{
		public static double Berechne(double zahl1, double zahl2, Rechenoperation operation)
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
						return zahl1 / zahl2;
					}
			}
			return double.NaN;
		}

		public static double ZahlEingabe(string text, string zahlAlsString)
		{
			bool allesOkay = false;
			double zahl;
			Console.Write(text);
			allesOkay = double.TryParse(zahlAlsString, out zahl);
			if (!allesOkay)
			{
				throw new FormatException("Ungültige Zahleneingabe.");
			}
			
			return zahl;
		}

		public static Rechenoperation RechenoperationEingabe(string zahlAlsString)
		{
			// Auswahl der Rechenoperation (Ausgabe aller Möglichkeiten)
			Console.WriteLine("\n" +
				"Wähle eine Rechenoperation aus: ");
			for (int i = 1; i <= 4; i++)
			{
				Console.WriteLine($"{i}: {(Rechenoperation)i}");
			}
			int auswahl;
			do
			{
				auswahl = (int)ZahlEingabe("", zahlAlsString);
				if (!(auswahl >= 1 && auswahl <= 4))
				{
					Console.WriteLine("Ungültige Auswahl. Bitte eine Zahl zwischen 1 und 4 eingeben.");
				}
			} while (!(auswahl >= 1 && auswahl <= 4));

			return (Rechenoperation)auswahl;
		}
	}
}
