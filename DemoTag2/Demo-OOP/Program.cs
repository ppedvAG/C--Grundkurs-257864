// Der Namespace "System" ist in .NET 8.0 standardmäßig verfügbar.
// Daher ist die using-Direktive für "System" nicht mehr zwingend erforderlich.
using System;
namespace Demo_OOP
{
	public static class Program
	{
		public static void Main()
		{
			// Weil System schon mit using standardmäßig eingebunden ist, brauche ich das System. nicht mehr zu schreiben.
			System.Console.WriteLine();

			SchulungsTeilnehmer teilnehmer1 = new SchulungsTeilnehmer("Marie", "Huber");

			Console.WriteLine("Vorname von Teilnehmer 1: " + teilnehmer1.Vorname);
			Console.WriteLine("Nachname von Teilnehmer 1: " + teilnehmer1.GetNachname());

			// Auf Methoden von Klassen kann man nicht über den Klassennamen zugreifen, sondern nur über eine Instanz der Klasse (Objekt)
			// SchulungsTeilnehmer.melden();
			teilnehmer1.Melden();

			SchulungsTeilnehmer schulungsTeilnehmer2 = new SchulungsTeilnehmer("Max", "Mustermann");
			schulungsTeilnehmer2.Melden();

			teilnehmer1.Alter = 25;
			// Alte Variante ist der Aufruf der Set-Methode erforderlich - nicht so elegant
			teilnehmer1.SetAnzahlBesuche(2);

			// neuer Teilnehmer mit mehr Parametern im Konstruktor
			SchulungsTeilnehmer teilnehmer3 = new SchulungsTeilnehmer("", "", 30, 5);

			teilnehmer3.Melden();

			Console.WriteLine($"Anzahl Teilnehmer: {SchulungsTeilnehmer.AnzahlTeilnehmer}");
			
			//for(int i = 0; i<100000000; i++)
			//{
			//	SchulungsTeilnehmer  t = new SchulungsTeilnehmer("Test", "Teilnehmer");
			//}
			//Console.WriteLine($"Anzahl Teilnehmer nach Schleife: {SchulungsTeilnehmer.AnzahlTeilnehmer}");

			Console.WriteLine(SchulungsTeilnehmer.GetClassDescription());

		}
	}
}
