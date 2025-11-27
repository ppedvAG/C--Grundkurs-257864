using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Fahrzeuge
{
	internal class PKW : Fahrzeug
	{
		public string Kennzeichen { get; set; }

		public PKW(string name, int maxGeschwindigkeit, double preis, string kennzeichen) : base(name, maxGeschwindigkeit, preis)
		{
			if(kennzeichen.Length < 3 || kennzeichen.Length > 8)
			{
				throw new KennzeichenFehlerException("Länge des Kennzeichen nicht okay");
			}
			if(kennzeichen.Any(c => !char.IsLetterOrDigit(c) && c != '-'))
			{
				throw new KennzeichenFehlerException("Ungültige Zeichen im Kennzeichen");
			}
			Kennzeichen = kennzeichen;
		}

		public override string Info()
		{
			return base.Info()+$" Kennzeichen: {Kennzeichen}";
		}

		// abstrakte Methode Hupen implementieren
		public override void Hupen()
		{
			Console.WriteLine("PKW Hupe: Tuuut Tuuut!");
		}
	}
}
