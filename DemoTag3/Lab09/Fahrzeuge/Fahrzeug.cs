namespace Lab09.Fahrzeuge
{
	public class Fahrzeug
	{
		// Eigenschaften
		public string Name { get; private set; } = "Unbekannt";

		// Maximale Geschwindigkeit in km/h standardmäßig 130
		public int MaxGeschwindigkeit { get; private set; } = 130;

		public int AktGeschwindigkeit { get; private set; } = 0;

		public double Preis { get; set; } = 0.0;
		public bool MotorLaeuft { get; private set; } = false;

		// Statische Eigenschaft zur Zählung der erstellten Fahrzeuge
		public static int FahrzeugAnzahl { get; private set; } = 0;

		// Konstruktor
		public Fahrzeug(string name, int maxGeschwindigkeit, double preis)
		{
			Name = name;
			MaxGeschwindigkeit = maxGeschwindigkeit;
			Preis = preis;
			// Jedes Mal, wenn ein Fahrzeug mit dem Konstruktor erstellt wird, wird die Fahrzeuganzahl erhöht
			FahrzeugAnzahl++;
		}

		// Statische Methode zur Abfrage der Fahrzeuganzahl
		public static string GetFahrzeugAnzahl()
		{
			return $"Es wurden bisher {FahrzeugAnzahl} Fahrzeuge erstellt.";
		}

		// Methoden
		public virtual string Info()
		{
			return $"Fahrzeug {Name}: Maximale Geschwindigkeit: {MaxGeschwindigkeit}, " +
				$"Aktuelle Geschwindigkeit: {AktGeschwindigkeit}, " +
				$"Motor läuft? {MotorLaeuft}, " +
				$"Preis: {Preis}";
		}

		// Überprüft, ob der Motor bereits läuft. Wenn ja, wird false zurückgegeben.
		// Wenn nein, wird der Motor gestartet und true zurückgegeben.
		public bool StarteMotor()
		{
			if (MotorLaeuft)
			{
				Console.WriteLine("Der Motor läuft bereits.");
				return false;
			}
			else
			{
				MotorLaeuft = true;
				return true;
			}
		}

		public bool StoppeMotor()
		{
			if (MotorLaeuft && AktGeschwindigkeit == 0)
			{
				MotorLaeuft = false;
				return true;
			} else if (!MotorLaeuft)
			{
				Console.WriteLine("Der Motor ist bereits aus.");
				return false;
			} else
			{
				Console.WriteLine("Der Motor kann nur gestoppt werden, wenn das Fahrzeug steht.");
				return false;
			}
		}

		// Beschleunigungsmethode mit allen Überprüfungen
		public int Beschleunige(int geschwindigkeitsZunahme)
		{
			if (!MotorLaeuft)
			{
				Console.WriteLine("Der Motor läuft nicht. Bitte starten Sie den Motor zuerst.");
			}
			else if (geschwindigkeitsZunahme < 0)
			{
				Console.WriteLine("Negative Beschleunigung nicht erlaubt.");
			}
			else if (AktGeschwindigkeit + geschwindigkeitsZunahme > MaxGeschwindigkeit)
			{
				Console.WriteLine("Die Maximale Geschwidnigkeit wurde bereits erreicht.");
				AktGeschwindigkeit = MaxGeschwindigkeit;
			}
			else
			{
				AktGeschwindigkeit += geschwindigkeitsZunahme;
			}
			return AktGeschwindigkeit;
		}


		// Bremsmethode mit allen Überprüfungen
		public int Bremse(int geschwindigkeitsAbnahme)
		{
			if (geschwindigkeitsAbnahme < 0)
			{
				Console.WriteLine("Negative Bremsung nicht erlaubt.");
			}
			else if (AktGeschwindigkeit - geschwindigkeitsAbnahme < 0)
			{
				Console.WriteLine("Das Fahrzeug steht jetzt.");
				AktGeschwindigkeit = 0;
			}
			else
			{
				AktGeschwindigkeit -= geschwindigkeitsAbnahme;
			}
			return AktGeschwindigkeit;
		}

	}
}
