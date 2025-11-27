using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.Fahrzeuge
{
	internal class Schiff : Fahrzeug
	{
		public int Tiefgang { get; set; } // in Metern

		public Schiff(string name, int maxGeschwindigkeit, double preis, int tiefgang)
			: base(name, maxGeschwindigkeit, preis)
		{
			Tiefgang = tiefgang;
		}

		public override string Info()
		{
			return base.Info() + $" Tiefgang: {Tiefgang}";
		}
	}
}
