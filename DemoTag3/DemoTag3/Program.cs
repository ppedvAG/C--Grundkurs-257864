namespace DemoTag3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Objekte können von der Basisklasse oder der abgeleiteten Klasse erstellt werden
			
			Lebewesen lebewesen = new Lebewesen(new DateTime(2010, 5,5));
			Console.WriteLine(lebewesen.Info());

			Mensch mensch = new Mensch("Max", "Mustermann", new DateTime(1990, 12, 15));
			Console.WriteLine(mensch.Info());

			//mensch.Alter = 10; // Fehler: Alter hat einen protected set-Accessor
			//lebewesen.Geburtstag = new DateTime(2000, 1, 1); // Kein Fehler: Geburtstag hat einen private set-Accessor
		}
	}
}
