using Lab10.Fahrzeuge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
	// Schnittstelle für beladbare Objekte
	interface IBeladbar
	{
		// in GeladenesFahrzeug wird das aktuell geladene Fahrzeug gespeichert
		Fahrzeug GeladenesFahrzeug { get; protected set; }

		// Methode zum Beladen eines Fahrzeugs
		void BeladeFahrzeug(Fahrzeug fahrzeug);
		
		// Methode zum Entladen eines Fahrzeugs
		Fahrzeug EntladeFahrzeug();
	}
}
