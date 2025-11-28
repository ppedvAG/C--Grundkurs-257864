using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.Json.Serialization;

namespace DemoTag4
{
	public class Country
	{
		public string Name { get; set; }
		public int Population { get; set; }
		public double YearlyChange { get; set; }
		public int NetChange { get; set; }
		public int Density { get; set; }
		public int LandArea { get; set; }
		public int Migrants { get; set; }
		public double FertRate { get; set; }
		public int MedAge { get; set; }
		public int UrbanPopPtc { get; set; }
		public double WorldSharePtc { get; set; }

		[JsonConstructor]
		public Country(string name, int population, double yearlyChange, int netChange, int density, int landArea, int migrants, double fertRate, int medAge, int urbanPopPtc, double worldSharePtc)
		{
			Name = name;
			Population = population;
			YearlyChange = yearlyChange;
			NetChange = netChange;
			Density = density;
			LandArea = landArea;
			Migrants = migrants;
			FertRate = fertRate;
			MedAge = medAge;
			UrbanPopPtc = urbanPopPtc;
			WorldSharePtc = worldSharePtc;
		}

		// Konstruktor, der ein Dictionary-Eintrag entgegennimmt und die Werte konvertiert
		public Country(string key, string[] values) 
		{
			Name = key;
			Population = int.Parse(values[0]);
			YearlyChange = double.Parse(values[1], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
			NetChange = int.Parse(values[2]);
			Density = int.Parse(values[3]);
			LandArea = int.Parse(values[4]);
			Migrants = int.Parse(values[5]);
			FertRate = double.Parse(values[6], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);
			MedAge = int.Parse(values[7]);
			UrbanPopPtc = int.Parse(values[8]);
			WorldSharePtc = double.Parse(values[9], System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture);

		}
	}
}
