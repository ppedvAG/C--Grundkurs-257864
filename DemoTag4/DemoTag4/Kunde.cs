using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTag4
{
	internal class Kunde <T>
	{
		public string Name { get; set; }
		public List<T> Sachen { get; private set; }

		public Kunde(string name)
		{
			Name = name;
			Sachen = new List<T>();
		}

		public void Hinzufügen (T ding)
		{
			Sachen.Add(ding);
		}
	}
}
