
class Program
{
	static void Main(string[] args)
	{
		//		// neue Varible Nummer1 zuweisen mit 13
		//		int Nummer1 = 13;

		//		// zweite Variable Nmmer2 zuweisen mit 29
		//		int Nummer2 = 29;

		//		// Dritte Variable Name mit "Dominik" zuweisen
		//		string Name = "Dominik Enzenhofer";


		//		// Ausgabe der Variablen in der Kosonole mit dem Behfehl Console.WriteLine
		//		Console.WriteLine(Name + " hat die Nummern " + Nummer1 + " und " + Nummer2 + " zugewiesen.");
		//		// 13 (int Nummer1) wird umgewandelt in "13" (string)

		//		// Index Schreibweise mit Platzhaltern
		//		Console.WriteLine("{0} hat die Nummern {1} und {2} zugewiesen.", Name, Nummer1, Nummer2);

		//		// Darstellung mit $-Zeichen (String Interpolation)
		//		Console.WriteLine($"{Name} hat die Nummern {Nummer1} und {Nummer2} zugewiesen.");


		//		// Unterschied zwischnen Deklaration und Zuweisung
		//		int Nummer3; // Deklaration - die Variable wird erstellt, hat aber noch keinen Wert
		//		// Console.WriteLine(Nummer3); -> würde einen Fehler geben, da Nummer3 noch keinen Wert hat

		//		Nummer3 = 42; // Zuweisung - der Variable wird ein Wert zugewiesen
		//		Console.WriteLine("Nummer3 hat den Wert: " + Nummer3);


		//		Console.WriteLine("Zeile eins\n" +
		//			"Zeile zwei\ttabulator");

		//		Console.WriteLine(@"Zeile eins
		//Zeile zwei");



		//		// Konsoleneingabe

		//		Console.WriteLine("Bitte geben Sie etwas ein: ");
		//		// Liest eine Zeile von der Konsole ein ud speichert sie in der Variable strEingabe
		//		string strEingabe = Console.ReadLine(); 

		//		// Eingabe von Zahlen
		//		Console.WriteLine("Bitte geben Sie eine ganze Zahl ein: ");
		//		int intEingabe = int.Parse(Console.ReadLine());

		//		Console.WriteLine("Bitte geben Sie eine Kommazahl ein: ");
		//		double doubleEingabe = double.Parse(Console.ReadLine());

		//		Console.WriteLine($"Sie haben folgenden Text eingegeben: \n" +
		//			$"String: \t{strEingabe}\n" +
		//			$"Int: \t\t{intEingabe}\n" +
		//			$"Double: \t{doubleEingabe}");

		//		Console.WriteLine("\n\n");

		// Mathematische Operationen

		//int a = 10;
		//int b = 3;

		//Console.WriteLine($"a = {a}, b = {b}");

		//int summe = a + b;
		//Console.WriteLine($"a + b = {summe}");
		//Console.WriteLine($"a + b = {a+b}");

		//int differenz = a - b;
		//int multiplikation = a * b;
		//double division = a / b;
		//Console.WriteLine("a / b =" + division);
		//double divisionGenau = (double)a / (double)b;
		//Console.WriteLine("a / b =" + divisionGenau);

		//// erhöhe a um 3 und veringere b um 6

		////a = a + 3;
		////a++;a++; a++;
		//a += 3; // Kurzschreibweise für a = a + 3;
		//b -= 6; // Kurzschreibweise für b = b - 6;

		//// Zahl runden.
		//Console.WriteLine("gerundet: "+Math.Round(divisionGenau));
		//Console.WriteLine("gerundet: " + Math.Round(divisionGenau, 2));

		// Arrays in C#

		//int[] zahlen1 = new int[5];
		//int[] zahlen2 = new int[] { 10, 20, 30, 40, 50 };

		//zahlen1[0] = 1;
		//zahlen1[1] = 2;
		//zahlen1[2] = 3;
		//zahlen1[3] = 4;
		//zahlen1[4] = 5;
		////zahlen1[5] = 6; // Error: IndexOutOfRangeException

		//Console.WriteLine(zahlen2[3]);
		//Console.WriteLine(zahlen1[4]);
		//Console.WriteLine(zahlen1);

		//// Größtes Element
		//Console.WriteLine("Größtes Element in zahlen2: "+ zahlen2.Max());
		//// Kleinstes Element
		//Console.WriteLine("Kleinstes Element in zahlen2: " + zahlen2.Min());
		//// Summe aller Elemente
		//Console.WriteLine("Summe aller Elemente in zahlen2: " + zahlen2.Sum());
		//// Kommt 5 in zahlen2 vor?
		//Console.WriteLine("Kommt 5 in zahlen2 vor? " + zahlen2.Contains(5));

		//// Mehrdimsionales Array (2D)
		//string[,] vorUndNachnamen = new string[2, 3];
		//vorUndNachnamen[0, 0] = "Max";
		//vorUndNachnamen[1, 0] = "Mustermann";
		//vorUndNachnamen[0, 1] = "Maja";
		//vorUndNachnamen[1, 1] = "Musterfrau";
		//vorUndNachnamen[0, 2] = "Kelly";
		//vorUndNachnamen[1,2] = "Smith";

		// Bedingungen (if & else)
		Console.WriteLine("Geben Sie eine Zahl ein: ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Geben Sie eine weitere Zahl ein: ");
		int b = int.Parse(Console.ReadLine());

		if (a == b)
		{
			Console.WriteLine("gleich");
		}
		else if (a < b)
			Console.WriteLine($"{a} ist kleiner als {b}");
		else
			Console.WriteLine($"{a} ist größer als {b}");

		Console.WriteLine("geben sie den Namen ein: ");
		string name = Console.ReadLine();
		if (a == b && (name.StartsWith("D") || name.StartsWith("d")))
		{
			Console.WriteLine("Der Name fängt mit D an und die beiden Zahlen sind gleich groß");
		}

	}
}
