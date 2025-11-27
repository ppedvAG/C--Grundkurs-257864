namespace DemoTag3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Objekte können von der Basisklasse oder der abgeleiteten Klasse erstellt werden

			//Lebewesen lebewesen = new Lebewesen(new DateTime(2010, 5,5));
			//Console.WriteLine(lebewesen.Info());

			//Mensch mensch = new Mensch("Max", "Mustermann", new DateTime(1990, 12, 15));
			//Console.WriteLine(mensch.Info());

			////mensch.Alter = 10; // Fehler: Alter hat einen protected set-Accessor
			////lebewesen.Geburtstag = new DateTime(2000, 1, 1); // Kein Fehler: Geburtstag hat einen private set-Accessor

			//// Array von Lebewesen, das sowohl Menschen als auch Tiere enthalten kann
			//// Polimorphismus: Ein Lebewesen kann ein Mensch oder ein Tier sein
			//// --> ich darf in das Array von Lebwesen sowohl Objekte vom Typ Lebwesen, oder Menschen als auch Tiere speichern
			//Lebewesen[] lebewesenArray = new Lebewesen[5];
			//lebewesenArray[0] = new Lebewesen(new DateTime(1985, 3, 20));
			//// schleife die Zufällig ein Tier oder einen Mensch erstellt und dem Array hinzufügt
			//Random random = new Random();
			//for(int i = 1; i < lebewesenArray.Length; i++)
			//{
			//	if(random.Next(2) == 0)
			//	{
			//		lebewesenArray[i] = new Mensch("Vorname"+i, "Nachname"+i, new DateTime(1980 + i, 1, 1));
			//	}
			//	else
			//	{
			//		lebewesenArray[i] = (Lebewesen) new Tier("Spezies"+i, new DateTime(2015 + i, 1, 1));
			//	}
			//}

			//// Ausgabe der Info aller Lebewesen im Array
			//foreach(Lebewesen l in lebewesenArray)
			//{
			//	// GetType gibt uns den tatsächlichen Typ des Objekts zurück
			//	Console.WriteLine(l.GetType().Name);
			//}
			//// mit is -Operator prüfen ob ein Lebewesen im Array mit dem Typ Mensch kompatibel ist
			//Console.WriteLine($"Ist {lebewesenArray[1].Info()} ein Mensch? {lebewesenArray[1] is Mensch}");
			//// mit is-Operator prüfen ob ein Objekt im Array mit dem Typ Lebewesen kompatibel ist
			//Console.WriteLine($"Ist {lebewesenArray[2].Info()} ein Lebewesen? {lebewesenArray[2] is Lebewesen}"); // immer true
			//// mit is-Operator prüfen ob ein Objekt im Array mit dem Typ Objekt kompatibel ist
			//Console.WriteLine($"Ist {lebewesenArray[2].Info()} ein Lebewesen? {lebewesenArray[3] is object}"); // immer true


			// Lebewesen ist jetzt Abstrakt, deswegen kann ich kein Objekt mehr davon erstellen
			//Lebewesen lebewesen = new Lebewesen(new DateTime(2010, 5,5)); // Fehler

			// nur Objekte von abgeleiteten Klassen können erstellt werden, weil Lebewesen Abstrakt ist
			Lebewesen mensch = new Mensch("Max", "Mustermann", new DateTime(1990, 12, 15));
			Lebewesen tier = new Tier("Hund", new DateTime(2018, 6, 1));

		}
	}
}
