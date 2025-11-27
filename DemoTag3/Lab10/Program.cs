using Lab10.Fahrzeuge;

namespace Lab10
{
	public class Program
	{
		public static void Main()
		{
			//Container container = new Container("Container 1");
			//Fahrzeug fahrzeug1 = Fahrzeug.GeneriereFahrzeug("Fahrzeug 1");
			//container = (Container)BeladeObjekt(container, fahrzeug1);
			//Console.WriteLine("Container 1 beladen mit: " + container.GeladenesFahrzeug.ToString());

			//Schiff schiff1 = new Schiff("Schiff 1", 50, 5_000_000, 15);
			//Fahrzeug fahrzeug2 = Fahrzeug.GeneriereFahrzeug("Fahrzeug 2");
			//schiff1 = (Schiff)BeladeObjekt(fahrzeug2, schiff1);
			//Console.WriteLine(schiff1.Info());

			//Schiff schiff3 = new Schiff("Schiff 3", 60, 6_000_000, 20);
			//Schiff schiff4 = new Schiff("Schiff 4", 60, 6_000_000, 20);
			//schiff3 = (Schiff) BeladeObjekt(schiff3, schiff4, false);
			//Console.WriteLine(schiff3.Info());
			//schiff3.EntladeFahrzeug();
			//schiff4 = (Schiff) BeladeObjekt(schiff3, schiff4, true);
			//Console.WriteLine(schiff4.Info());


			// Exception Testen

			try
			{
				PKW pkw1 = new PKW("MeinPKW", 180, 10000, "&%lk");
			} catch(KennzeichenFehlerException e)
			{
				Console.WriteLine("Fehler beim Erstellen des PKW: " + e.Message);
			}


			try
			{
				PKW pkw1 = new PKW("MeinPKW", 180, 10000, "WERUIOHFEHEWF");
			}
			catch (KennzeichenFehlerException e)
			{
				Console.WriteLine("Fehler beim Erstellen des PKW: " + e.Message);
			}

		}

		static Object BeladeObjekt(Object obj1, Object obj2)
		{
			if(obj1 is IBeladbar && obj2 is Fahrzeug)
			{
				IBeladbar beladbaresObjekt = (IBeladbar)obj1;
				beladbaresObjekt.BeladeFahrzeug((Fahrzeug)obj2);
				return beladbaresObjekt;
			} else if (obj2 is IBeladbar && obj1 is Fahrzeug)
			{
				IBeladbar beladbaresObjekt = (IBeladbar)obj2;
				beladbaresObjekt.BeladeFahrzeug((Fahrzeug)obj1);
				return beladbaresObjekt;
			}
			return null;
		}

		static Object BeladeObjekt(Object obj1, Object obj2, bool erstesAufZweites)
		{
			if (!erstesAufZweites && obj1 is IBeladbar && obj2 is Fahrzeug)
			{
				IBeladbar beladbaresObjekt = (IBeladbar)obj1;
				beladbaresObjekt.BeladeFahrzeug((Fahrzeug)obj2);
				return beladbaresObjekt;
			}
			else if (erstesAufZweites && obj2 is IBeladbar && obj1 is Fahrzeug)
			{
				IBeladbar beladbaresObjekt = (IBeladbar)obj2;
				beladbaresObjekt.BeladeFahrzeug((Fahrzeug)obj1);
				return beladbaresObjekt;
			} 
			return null;
		}
	}
}
