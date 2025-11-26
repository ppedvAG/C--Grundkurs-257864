public class Program
{
	public static void Main()
	{
		bool wiederholen = false;
		bool eingabeOk = false;
		int zahl;
		do
		{
			Console.Write("Bitte eine ganze Zahl größer als 1 eingeben: ");
			eingabeOk = int.TryParse(Console.ReadLine(), out zahl);
			if (!eingabeOk || zahl <=1)
			{
				Console.WriteLine("Ungültige Eingabe. Bitte eine ganze Zahl, die größer als 1 ist eingeben.");
				continue;
			}

			// Primzahlprüfung
			bool istPrimzahl = true;
			for (int i = 2; i<zahl; i++)
			{
				if(zahl%i==0)
				{
					istPrimzahl = false;
				}
			}

			Console.WriteLine($"Ist {zahl} eine Primzahl? "+istPrimzahl);



			Console.WriteLine("Möchten Sie eine weitere Primzahlprüfung durchführen? (J/N)");
			wiederholen = Console.ReadKey().Key == ConsoleKey.J;
			Console.WriteLine();
		} while (wiederholen || !eingabeOk || zahl<=1);

	}
}