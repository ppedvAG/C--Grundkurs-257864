using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTag3
{
	public class Mensch : Lebewesen
	{

		// Geburtstag und Alter erbt die Klasse Mensch von der Basisklasse Lebewesen.
		public string Vorname { get; private set; }
		public string Nachname { get; private set; }

		// mit : base(geburtsTag) rufe ich den Konstruktor der Basisklasse auf und übergebe den geburtsTag Parameter.
		public Mensch(string vorname, string nachname, DateTime geburtstag) : base(geburtstag)
		{
			Vorname = vorname;
			Nachname = nachname;
		}


		// Mit override kann ich eine Methode überschreiben, die in der Basisklasse als virtual deklariert wurde.
		public override string Info()
		{
			// mit base. kann ich auf die Basisklasse zugreifen.
			string lebewesenInfo = base.Info().Substring(0, base.Info().Length - 1);
			return $"{lebewesenInfo} und ich heiße {Vorname} {Nachname}.";
		}

		//public void alterBearbeiten(int alter)
		//{
		//	// Kein Fehler: Alter hat einen protected set-Accessor
		//	Alter = alter;
		//}
		//public void geburtstagBearbeiten(DateTime geburtstag)
		//{
		//	// Fehler: Geburtstag hat einen private set-Accessor
		//	Geburtstag = geburtstag;
		//}
	}
}
