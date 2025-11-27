using Lab10.Fahrzeuge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
	internal class Container: IBeladbar
	{
		public string Name { get; set; }

		// Das Fahrzeug, das im Container geladen ist muss implementiert werden weil IBeladbar es vorschreibt
		public Fahrzeug GeladenesFahrzeug { get; set; } = null;
		public Container(string name)
		{
			Name = name;
		}

		// Methoden der Schnittstelle IBeladbar müssen implementiert werden (sie sind standardmäßig abstract)
		public void BeladeFahrzeug(Fahrzeug fahrzeug)
		{
			if(GeladenesFahrzeug == null)
			{
				GeladenesFahrzeug = fahrzeug;
				Console.WriteLine($"Das Fahrzeug {fahrzeug.Name} wurde in den Container {Name} geladen.");
			} else
			{
				Console.WriteLine($"Der Container {Name} ist bereits mit dem Fahrzeug {GeladenesFahrzeug.Name} beladen.");
			}
		}

		public Fahrzeug EntladeFahrzeug()
		{
			if(GeladenesFahrzeug == null)
			{
				Console.WriteLine($"Der Container {Name} ist leer. Es kann kein Fahrzeug entladen werden.");
				return null;
			}
			Fahrzeug aktuellesFahrzeug = GeladenesFahrzeug;
			GeladenesFahrzeug = null;
			return aktuellesFahrzeug;
		}
	}
}
