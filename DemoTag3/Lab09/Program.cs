using Lab09.Fahrzeuge;

namespace Lab09
{
	public class Program
	{
		public static void Main()
		{
			Flugzeug boeing = new Flugzeug("Boeing 747", 800, 10_000_000, 8000);
			PKW toyota = new PKW("Toyota Yaris", 190, 25_000, "W-AB 1234");
			Schiff titanic = new Schiff("Titanic", 40, 10_000_000, 10);

			Console.WriteLine(boeing.Info());
			Console.WriteLine(toyota.Info());
			Console.WriteLine(titanic.Info());

			Console.WriteLine(Fahrzeug.GetFahrzeugAnzahl());
		}
	}
}
