using System.Text.Json;

namespace DemoTag4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Collections
			//// Collections: List, Dictionary, HashSet, etc.
			//// Sammlung von Daten in einer strukturierten Weise
			//// Alle Collections erben von IEnumerable oder ICollection

			//// Unterschied zwischen Array und List
			//// Array: Feste Größe, gleiche Datentypen
			//// List: Dynamische Größe, gleiche Datentypen
			//// Beispiel für List
			//List<int> zahlenListe = new List<int> { 1, 2, 3, 3, 4, 5 };

			//// Liste ausgeben
			//foreach ( int zahl in zahlenListe )
			//{
			//	Console.Write(zahl + " ");
			//}
			//Console.WriteLine();

			//// Belieg viele Methoden zur Manipulation von Listen
			//// Belieg viele Elemente hinzufügen und löschen.
			//zahlenListe.Add(6); // Hinzufügen wird am Ende der Liste hinzugefügt
			//foreach (int zahl in zahlenListe)
			//{
			//	Console.Write(zahl + " ");
			//}
			//Console.WriteLine();

			//zahlenListe.Remove(3); // entfernt das erste Vorkommen des Elements
			//foreach (int zahl in zahlenListe)
			//{
			//	Console.Write(zahl + " ");
			//}
			//Console.WriteLine();

			//// Weiter nützliche Methoden von Listen
			//Console.WriteLine("Anzahl der Elemente in der Liste: " + zahlenListe.Count); // Anzahl der Elemente in der Liste

			//// Element an einer bestimmten Stelle der Liste einfügen
			//zahlenListe.Insert(1, 10); // Fügt die Zahl 10 an Index 1 ein

			//foreach (int zahl in zahlenListe)
			//{
			//	Console.Write(zahl + " ");
			//}
			//Console.WriteLine();

			//zahlenListe.Sort(); // Sortiert die Liste

			//foreach (int zahl in zahlenListe)
			//{
			//	Console.Write(zahl + " ");
			//}
			//Console.WriteLine();

			//// Dictionary: Listen mit Schlüssel-Wert-Paare
			//// Schlüssel sind eindeutig und werden verwendet, um auf Werte zuzugreifen
			//// Schlüssel können verschiedene Datentypen haben

			//Dictionary<string, int> alterDictionary = new Dictionary<string, int>();
			//alterDictionary.Add("Alice", 30);
			//alterDictionary.Add("Bob", 25);
			//// Werte können gleich sein
			//alterDictionary.Add("Charlie", 30);
			//try
			//{
			//	// Schlüssel müssen eindeutig sein
			//	alterDictionary.Add("Alice", 35);
			//} catch (ArgumentException ex) {
			//	Console.WriteLine("Fehler: " + ex.Message);
			//}


			//for (int i = 30; i < 50; i++)
			//{
			//	alterDictionary.Add("Person" + (i - 29), i);
			//}

			//// Dictionary ausgeben
			//foreach (var eintrag in alterDictionary)
			//{
			//	// Mit Key und Value auf Schlüssel und Wert zugreifen
			//	Console.WriteLine(eintrag.Key + ": " + eintrag.Value);
			//}


			//// Generische Liste von Kunden verwenden mit verschiedenen Datentypen
			//Kunde<string> kunde1 = new Kunde<string>("Max");
			//Kunde<DateTime> kunde2 = new Kunde<DateTime>("Maya");

			//kunde1.Hinzufügen("Laptop");
			//kunde1.Hinzufügen("Smartphone");
			//kunde2.Hinzufügen(DateTime.Now);
			//kunde2.Hinzufügen(new DateTime(2023, 12, 25));

			#endregion

			#region Dateioperationen
			// CSV Datei lesen mit CsvReader Klasse
			//string filePath = "C:\\Users\\de2\\OneDrive - ppedv AG\\Anlagen\\Schulungsunterlagen\\C# Grundkurs\\C--Grundkurs-257864\\DemoTag4\\DemoTag4\\Data\\PopulationDataFertig.csv";

			//try
			//{
			//	Dictionary<string, string[]> populationData = DataManipulator.ReadCsv(filePath);
			//	foreach (var eintrag in populationData)
			//	{
			//		Console.Write(eintrag.Key + ": ");
			//		foreach (var value in eintrag.Value)
			//		{
			//			Console.Write(value + ", ");
			//		}
			//		Console.WriteLine();
			//	}

			//	Dictionary<string, Country> countries = new Dictionary<string, Country>();
			//	foreach( var eintrag in populationData)
			//	{
			//		Country country = new Country(eintrag.Key, eintrag.Value);
			//		countries.Add(eintrag.Key, country);
			//	}
			//	Console.WriteLine(countries.First().Key);

			//	// Daten in eine Json Datei speichern
			//	string jsonFilePath = "C:\\Users\\de2\\OneDrive - ppedv AG\\Anlagen\\Schulungsunterlagen\\C# Grundkurs\\C--Grundkurs-257864\\DemoTag4\\DemoTag4\\Data\\PopulationData.json";
			//	DataManipulator.SaveToJson<Country>(jsonFilePath, countries);

			//}
			//catch (FileNotFoundException ex)
			//{
			//	Console.WriteLine("Fehler: " + ex.Message);
			//} catch (FormatException ex)
			//{
			//	Console.WriteLine("Fehler beim Konvertieren der Daten: " + ex.Message);
			//}

			#endregion

			#region Linq Funkionen & Lamda Ausdrücke

			//// Erstellt eine Liste von Startwert mit einer Bestimmten Anzahl von Elementen
			//// (5, 29) -> Start bei 5, 20 Elemente -> 5-25
			//List<int> zahlen = Enumerable.Range(0, 20).ToList(); // Zahlen 0 bis 19

			//// Alle Zahlen ausgeben mit einer Lambda Funktion
			//zahlen.ForEach(e => Console.Write(e + " "));
			//Console.WriteLine();

			//// zahlen.ForEach ist gleich wie eine foreach Schleife
			////foreach (int e in zahlen)
			////{
			////	Console.Write(e + " ");
			////}

			//// Einfache Linq Funktionen die einen Wert zurückgeben und keine Collection:

			//Console.WriteLine(zahlen.Average()); // Durchschitt
			//Console.WriteLine(zahlen.Min()); // Minimum
			//Console.WriteLine(zahlen.Max()); // Maximum
			//Console.WriteLine(zahlen.Sum()); // Summe

			//Console.WriteLine(zahlen.First()); // Erstes Element
			//Console.WriteLine(zahlen.FirstOrDefault()); // Erstes Element oder Standardwert (0 für int)
			//Console.WriteLine(zahlen.Last()); // Letztes Element
			//Console.WriteLine(zahlen.LastOrDefault()); // Letztes Element oder Standardwert (0 für int)

			//Console.WriteLine(zahlen.Single(e => e == 2)); // Einzelnes Element, das die Bedingung erfüllt (2)
			//Console.WriteLine(zahlen.SingleOrDefault(e => e == 100)); // Einzelnes Element oder Standardwert (0 für int), wenn nicht gefunden

			//// Komplexere Linq Funktionen die eine Collection zurückgeben:

			//// Liste der Countries aus der Json Datei laden
			//string jsonFilePath = "C:\\Users\\de2\\OneDrive - ppedv AG\\Anlagen\\Schulungsunterlagen\\C# Grundkurs\\C--Grundkurs-257864\\DemoTag4\\DemoTag4\\Data\\PopulationData.json";
			//string jsonContent = File.ReadAllText(jsonFilePath);
			//List<Country> countries = new List<Country> (JsonSerializer.Deserialize<Dictionary<string, Country>>(jsonContent).Values);


			//// Alle Countries mit einer Population über 100 Millionen
			////Console.WriteLine("Countries mit Population über 100 Millionen: ");
			////countries.Where(e => e.Population > 100_000_000).ToList().ForEach(e => Console.WriteLine(e.Name + ": " + e.Population));

			//// Countries sortiert nach Population aufsteigend
			////Console.WriteLine("Countries sortiert nach Population aufsteigend: ");
			////countries.OrderBy(e => e.Population).ToList().ForEach(e=> Console.WriteLine(e.Name + ": " + e.Population));

			//// Welches Countrys haben eine Population größer als der Durchschnitt aller Countries
			//Console.WriteLine("Countries mit Population größer als der Durchschnitt: ");
			//double durchschnittPopulation = countries.Average(e => e.Population);
			//countries.Where(e=> e.Population > durchschnittPopulation).ToList().ForEach(e => Console.WriteLine(e.Name + ": " + e.Population));
			#endregion

			#region Erweiterungsmethoden
			// Variante mit normer Methode
			Console.WriteLine(Erweiterungsmethoden.GetQuersumme(685140));
			// Variante mit Erweiterungsmethode
			Console.WriteLine(685140.GetQuersumme()); // 6 + 8 + 5 + 1 + 4 + 0 = 24
			#endregion

		}
	}
}