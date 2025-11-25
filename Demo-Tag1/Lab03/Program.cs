public class Program
{
	enum Rechenoperation
	{
		Addition = 1, Subtraktion, Multiplikation, Division
	}
	public static void Main(string[] args)
	{
		int zahl1, zahl2;
		Rechenoperation rechenoperation;
		bool allesOkay = false;

		Console.Write("Gib eine Zahl ein: ");
		allesOkay = int.TryParse(Console.ReadLine(), out zahl1);
		if (allesOkay)
		{
			Console.Write("Gib eine weitere Zahl ein: ");
			allesOkay = int.TryParse(Console.ReadLine(), out zahl2);
			if(allesOkay)
			{
				Console.WriteLine("\n" +
					"Wähle eine Rechenoperation aus: ");
				for(int i = 1; i <=4; i++)
				{
					Console.WriteLine($"{i}: {(Rechenoperation)i}");
				}
				int auswahl;
				allesOkay = int.TryParse(Console.ReadLine(), out auswahl);
				if(allesOkay && auswahl >=1 && auswahl <=4)
				{
					rechenoperation = (Rechenoperation)auswahl;
					switch(rechenoperation)
					{
						case Rechenoperation.Addition:
							Console.WriteLine("Ergebnis: " + (zahl1 + zahl2));
							break;
						case Rechenoperation.Subtraktion:
							Console.WriteLine("Ergebnis: " + (zahl1 - zahl2));
							break;
						case Rechenoperation.Multiplikation:
							Console.WriteLine("Ergebnis: " + (zahl1 * zahl2));
							break;
						case Rechenoperation.Division:
							if (zahl2 == 0)
							{
								Console.WriteLine("Division dur 0 nicht erlaubt");
								break;
							} else
							{
								Console.WriteLine("Ergebnis: " + (zahl1 / zahl2));
								break;
							}

					}
				}

			}
		}

	}
}
