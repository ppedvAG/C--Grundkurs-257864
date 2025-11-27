using Lab10.Fahrzeuge;

namespace Lab10
{
	public class Program
	{
		public static void Main()
		{
			Fahrzeug[] fahrzeuge = new Fahrzeug[10];

			// Fahrzeuge generieren
			for (int i = 0; i<10; i++)
			{
				fahrzeuge[i] = Fahrzeug.GeneriereFahrzeug("Name" + i);
				Console.WriteLine(fahrzeuge[i].ToString());
			}

			// foreach ist hier nicht zu gebrauchen, weil wir auf die Elemente des Arrays zugreifen und diese verändern müssen
			//foreach (Fahrzeug element in fahrzeuge)
			//{
			//	element = Fahrzeug.GeneriereFahrzeug("Name");
			//}

			Console.WriteLine("\n"+Fahrzeug.GetFahrzeugAnzahl());

			int anzahlPKW = 0;
			int anzahlSchiff = 0;
			int anzahlFlugzeug = 0;

			// Anzahl der Fahrzeugtypen zählen
			foreach(Fahrzeug fz in fahrzeuge)
			{
				if(fz is PKW)
				{
					anzahlPKW++;
				} else if(fz is Schiff)
				{
					anzahlSchiff++;
				} else
				{
					anzahlFlugzeug++;
				}
			}

			// Ergebnisse ausgeben
			Console.WriteLine($"Anzahl PKW: {anzahlPKW}");
			Console.WriteLine($"Anzahl Schiff: {anzahlSchiff}");
			Console.WriteLine($"Anzahl Flugzeug: {anzahlFlugzeug}\n");

			fahrzeuge[2].Hupen();
		}
	}
}
