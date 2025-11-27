using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Fahrzeuge
{
	internal class Flugzeug : Fahrzeug
	{
		public int MaxFlughöhe { get; set; } // in Metern

		public Flugzeug(string name, int maxGeschwindigkeit, double preis, int maxFlughöhe)
			: base(name, maxGeschwindigkeit, preis)
		{
			MaxFlughöhe = maxFlughöhe;
		}

		public override string Info()
		{
			return base.Info() + $" Maximale Flughöhe: {MaxFlughöhe}";
		}

		// abstrakte Methode Hupen implementieren
		public override void Hupen()
		{
			Console.WriteLine("Flugzeughupe: Tuuut Tuuut!");
		}
	}
}
