using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.Fahrzeuge
{
	internal class PKW : Fahrzeug
	{
		public string Kennzeichen { get; set; }

		public PKW(string name, int maxGeschwindigkeit, double preis, string kennzeichen) : base(name, maxGeschwindigkeit, preis)
		{
			Kennzeichen = kennzeichen;
		}

		public override string Info()
		{
			return base.Info()+$" Kennzeichen: {Kennzeichen}";
		}
	}
}
