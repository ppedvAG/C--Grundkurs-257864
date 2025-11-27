using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTag3
{
	public class Lebewesen
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
		public virtual string Info()
		{
			return $"Ich bin ein Lebewesen im Alter von {Alter} Jahren.";
		}
	}
}
