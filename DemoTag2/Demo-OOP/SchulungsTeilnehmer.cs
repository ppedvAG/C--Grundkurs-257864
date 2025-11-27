
namespace Demo_OOP
{
	// klasse SchulungsTeilnehmer mit Eigenschaften und Methoden und Konstruktoren
	public class SchulungsTeilnehmer
	{

		// Statisches Member anzahlTeilnehmer um die Anzahl der erstellten Teilnehmer zu zählen
		public static int AnzahlTeilnehmer { get; private set; } = 0;

		// neue Variante für eine Eigenschaft (nur lesbar) BEVORZUGT
		public string Vorname { get; } = "Unbekannt"; // Standardwert "Unbekannt"

		// alte Variante für eine Eigenschaft (nur lesbar)
		private string nachname = "Unbekannt"; // Standardwert "Unbekannt"

		public string GetNachname()
		{
			return nachname;
		}

		// Statische Methode um die Beschreibung der Klasse zu erhalten
		public static string GetClassDescription()
		{
			// Es existieren mehrere Teilnehmer mit verschiedenen Vornamen, deswegen können wir in einer Statischen Methode darauf nicht zugreifen
			//Vorname = "";
			return "Die Klasse SchulungsTeilnehmer repräsentiert einen Teilnehmer an einer Schulung. Eigenschaften: Vorname, nachname";
		}

		// Dritte Eigenschaft Alter, die nicht kleiner als 0 sein darf
		private int alter;
		public int Alter
		{
			get { return alter; }
			set
			{
				if(value < 0)
				{
					alter = 0;
				} else
				{
					alter = value;
				}
			}
		}

		// alter Variante für eine Eigenschaft, die nicht kleiner als 0 sein darf
		private int anzahlBesuche = 0; // Standardwert 0
		public int GetAnzahlBesuche()
		{
			return anzahlBesuche;
		}
		public void SetAnzahlBesuche(int value)
		{
			if (value < 0)
			{
				anzahlBesuche = 0;
			}
			else
			{
				anzahlBesuche = value;
			}
		}


		// Standard-Konstruktor (ohne Parameter) exsistiert automatisch, wenn kein anderer Konstruktor definiert ist
		//public SchulungsTeilnehmer()
		//{

		//}

		// Methode Teilnehmer meldet sich
		public void Melden()
		{
			Console.WriteLine($"{Vorname} {nachname} möchte etwas sagen!");
		}

		// Konstruktor mit Parametern um die Eigenschaften Vorname und Nachname zu initialisieren
		public SchulungsTeilnehmer(string vorname, string nachname)
		{
			AnzahlTeilnehmer++; // Jedes Mal wenn ein neuer Teilnehmer erstellt wird, wird der Zähler erhöht
			alter = 0; // Standardwert für Alter setzen
			Vorname = vorname;
			this.nachname = nachname; // this verweist auf die aktuelle Instanz der Klasse (alte schreibweise, weil felder klein geschrieben werden)
		}

		// Konstruktor mit allen Parametern
		public SchulungsTeilnehmer(string vorname, string nachname, int alter, int anzahlBesuche) : this(vorname, nachname)
		{ 
			Alter = alter; 
			SetAnzahlBesuche(anzahlBesuche); 
		}

		~SchulungsTeilnehmer()
		{
			Console.WriteLine("Teilnehmer wird gelöscht: " + Vorname + " " + nachname);
			AnzahlTeilnehmer--; // Wenn ein Teilnehmer gelöscht wird, wird der Zähler verringert
		}


	}
}
