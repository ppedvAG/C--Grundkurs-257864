namespace DemoTag4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Collections: List, Dictionary, HashSet, etc.
			// Sammlung von Daten in einer strukturierten Weise
			// Alle Collections erben von IEnumerable oder ICollection

			// Unterschied zwischen Array und List
			// Array: Feste Größe, gleiche Datentypen
			// List: Dynamische Größe, gleiche Datentypen
			// Beispiel für List
			List<int> zahlenListe = new List<int> { 1, 2, 3, 3, 4, 5 };

			// Liste ausgeben
			foreach ( int zahl in zahlenListe )
			{
				Console.Write(zahl + " ");
			}
			Console.WriteLine();

			// Belieg viele Methoden zur Manipulation von Listen
			// Belieg viele Elemente hinzufügen und löschen.
			zahlenListe.Add(6); // Hinzufügen wird am Ende der Liste hinzugefügt
			foreach (int zahl in zahlenListe)
			{
				Console.Write(zahl + " ");
			}
			Console.WriteLine();

			zahlenListe.Remove(3); // entfernt das erste Vorkommen des Elements
			foreach (int zahl in zahlenListe)
			{
				Console.Write(zahl + " ");
			}
			Console.WriteLine();

			// Weiter nützliche Methoden von Listen
			Console.WriteLine("Anzahl der Elemente in der Liste: " + zahlenListe.Count); // Anzahl der Elemente in der Liste

			// Element an einer bestimmten Stelle der Liste einfügen
			zahlenListe.Insert(1, 10); // Fügt die Zahl 10 an Index 1 ein

			foreach (int zahl in zahlenListe)
			{
				Console.Write(zahl + " ");
			}
			Console.WriteLine();

			zahlenListe.Sort(); // Sortiert die Liste

			foreach (int zahl in zahlenListe)
			{
				Console.Write(zahl + " ");
			}
			Console.WriteLine();

			// Dictionary: Listen mit Schlüssel-Wert-Paare
			// Schlüssel sind eindeutig und werden verwendet, um auf Werte zuzugreifen
			// Schlüssel können verschiedene Datentypen haben

			Dictionary<string, int> alterDictionary = new Dictionary<string, int>();
			alterDictionary.Add("Alice", 30);
			alterDictionary.Add("Bob", 25);
			// Werte können gleich sein
			alterDictionary.Add("Charlie", 30);
			try
			{
				// Schlüssel müssen eindeutig sein
				alterDictionary.Add("Alice", 35);
			} catch (ArgumentException ex) {
				Console.WriteLine("Fehler: " + ex.Message);
			}


			for (int i = 30; i < 50; i++)
			{
				alterDictionary.Add("Person" + (i - 29), i);
			}

			// Dictionary ausgeben
			foreach (var eintrag in alterDictionary)
			{
				// Mit Key und Value auf Schlüssel und Wert zugreifen
				Console.WriteLine(eintrag.Key + ": " + eintrag.Value);
			}


			// Generische Liste von Kunden verwenden mit verschiedenen Datentypen
			Kunde<string> kunde1 = new Kunde<string>("Max");
			Kunde<DateTime> kunde2 = new Kunde<DateTime>("Maya");

			kunde1.Hinzufügen("Laptop");
			kunde1.Hinzufügen("Smartphone");
			kunde2.Hinzufügen(DateTime.Now);
			kunde2.Hinzufügen(new DateTime(2023, 12, 25));

		}
	}
}