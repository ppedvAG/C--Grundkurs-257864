namespace Lab06
{
	public class Program
	{
		public static void Main()
		{
			Fahrzeug auto = new Fahrzeug("Kombi", 180, 35000.0);
			Console.WriteLine(auto.Info());

			auto.StarteMotor();
			auto.StarteMotor();
			auto.StoppeMotor();
			auto.StoppeMotor();

			auto.Beschleunige(50); // Soll nicht funktionieren, Motor ist aus
			auto.StarteMotor();
			auto.Beschleunige(50); // Soll funktionieren
			Console.WriteLine(auto.Info());
			auto.Beschleunige(200); // Auto soll auf MaxGeschwindigkeit gehen
			Console.WriteLine(auto.Info());
			auto.StoppeMotor(); // Soll nicht funktionieren, Auto fährt noch
			auto.Beschleunige(-230); // Soll nicht funktionieren, da Geschwindigkeit nicht negativ werden darf
			Console.WriteLine(auto.Info());
			auto.Bremse(130); // Auto bremsen um 130 km/h
			Console.WriteLine(auto.Info());
			auto.Bremse(500); // Auto soll jetzt stehen
			Console.WriteLine(auto.Info());
			auto.StoppeMotor(); // Jetzt soll der Motor gestoppt werden können
			Console.WriteLine(auto.Info());
			auto.Bremse(-10); //Console.WriteLine(auto.Info());

		}
	}
}
