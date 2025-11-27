using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTag3
{
	// Lebewesen machen wir Abstrakt, damit niemand direkt ein Lebewesen erstellen kann.
	public abstract class Lebewesen : IBreathable
	{
		// protected set bedeutet, dass die Eigenschaft nur innerhalb der Klasse und in abgeleiteten Klassen gesetzt werden kann.
		public int Alter { get; protected set; }
		public DateTime Geburtstag { get; private set; }

		public Lebewesen(DateTime geburtstag)
		{
			Geburtstag = geburtstag;
			Alter = DateTime.Now.Year - geburtstag.Year;
		}

		// Wenn ich eine Methode als virtual deklariere, kann sie in einer abgeleiteten Klasse überschrieben werden.
		//public virtual string Info()
		//{
		//	return $"Ich bin ein Lebewesen im Alter von {Alter} Jahren.";
		//}

		// Wenn ich eine Methode als abstract deklariere, MUSS sie in einer abgeleiteten Klasse überschrieben werden.
		public abstract string Info(); // eine abstrakte Methode hat keine Implementierung


		// Alt + Enter um Vorschläge zum Hinzufügen anzuzeigen (Implementierung der Schnittstellen-Methoden)
		public virtual void BreatheIn() // virtual, damit abgeleitete Klassen die Methode überschreiben können
		{
			Console.WriteLine("Einatmen...");
			// Über das Interface auf die statische Eigenschaft zugreifen
			IBreathable.CountBreaths++;
		}

		public void BreatheOut()
		{
			Console.WriteLine("Ausatmen...");
		}
	}
}
