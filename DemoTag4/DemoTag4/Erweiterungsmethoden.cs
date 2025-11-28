using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTag4
{
	public static class Erweiterungsmethoden
	{
		public static int GetQuersumme(this int zahl)
		{
			int quersumme = 0;
			string zahlAlsString = zahl.ToString();
			for(int i = 0; i < zahlAlsString.Length; i++)
			{
				// Zahl als String: "1234" -> Zahl[0] = '1' -> '1' ist ein char, deswegen müssen wir es umwandeln in einen String, damit Parse funktioniert
				quersumme += int.Parse(zahlAlsString[i].ToString());
			}
			return quersumme;
		}
	}
}
