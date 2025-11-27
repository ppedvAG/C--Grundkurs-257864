using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTag3
{
	public class Tier : Lebewesen
	{

		// Geburtstag und Alter erbt die Klasse Mensch von der Basisklasse Lebewesen.
		public string Spezies { get; private set; }
		
		// mit : base(geburtsTag) rufe ich den Konstruktor der Basisklasse auf und übergebe den geburtsTag Parameter.
		public Tier(string spezies, DateTime geburtstag) : base(geburtstag)
		{
			Spezies = spezies;
		}

		// Ich muss die Methode Info() implementieren, da sie in der Basisklasse als abstract deklariert wurde.
		public override string Info()
		{
			 // base.Info(); // ich kann auch die Basisklassenmethode nicht aufrufen, weil die leer ist
			 return $"Tier: {Spezies}, Alter: {Alter}";
		}

		// Überschreibe die BreatheIn Methode, um das Zählen der Atemzüge zu ändern
		public override void BreatheIn()
		{
			Console.WriteLine($"Einatmen...");
			// Zugriff auf statische Eigenschaft CountBreaths über das Interface
			IBreathable.CountBreaths+=2;
		}


		// Mit override kann ich eine Methode überschreiben, die in der Basisklasse als virtual deklariert wurde.
		//public override string Info()
		//{
		//	// mit base. kann ich auf die Basisklasse zugreifen.
		//	string lebewesenInfo = base.Info().Substring(0, base.Info().Length - 1);
		//	return $"{lebewesenInfo} von der Spezies {Spezies}.";
		//}



	}
}
