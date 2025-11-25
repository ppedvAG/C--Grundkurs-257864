public class Program
{
	public static void Main(string[] args)
	{
		// Deklaration der Eingabevariablen
		int entfernungMeter;
		int zeitStunden;
		int zeitMinuten;
		int zeitSekunden;

		// Deklaration der Ausgabevariablen
		double geschwindigkeitMeterSekunde;
		double geschwindigkeitKilometerStunde;
		double geschwindigkeitMeilenStunde;

		// Benutzereingaben abfragen
		Console.Write("Entfernung (in Meter): ");
		entfernungMeter = int.Parse(Console.ReadLine());

		Console.Write("Stunden: ");
		zeitStunden = int.Parse(Console.ReadLine());

		Console.Write("Minuten: ");
		zeitMinuten = int.Parse(Console.ReadLine());

		Console.Write("Sekunden: ");
		zeitSekunden = int.Parse(Console.ReadLine());


		// Gesamtzeit in Sekunden berechnen
		int gesamtZeitSekunden = zeitSekunden + zeitMinuten * 60 + zeitStunden * 3600;

		Console.WriteLine($"Gesamtzeit in Sekunden: {gesamtZeitSekunden}");


		// Geschwindigkeiten berechnen
		geschwindigkeitMeterSekunde = (double)entfernungMeter / (double)gesamtZeitSekunden;
		geschwindigkeitKilometerStunde = ((double)entfernungMeter / 1000.0) / ((double)gesamtZeitSekunden / 3600.0);
		geschwindigkeitMeilenStunde = (((double)entfernungMeter) / (1000.0*1.609)) / ((double)gesamtZeitSekunden / 3600.0);

		// Ausgabe der Ergebnisse

		Console.WriteLine($"Meter/Sekunde: \t\t{Math.Round(geschwindigkeitMeterSekunde, 2)}");
		Console.WriteLine($"Kilometer/Stunde: \t{Math.Round(geschwindigkeitKilometerStunde, 2)}");
		Console.WriteLine($"Meilen/Stunde: \t\t{Math.Round(geschwindigkeitMeilenStunde, 2)}");
	}
}	
