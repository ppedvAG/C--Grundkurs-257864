using System.Diagnostics;
using System.Text.Json;

namespace Lab11;

internal class Program
{
	static void Main(string[] args)
	{
		#region File lesen
		string readJson = File.ReadAllText("C:\\Users\\de2\\OneDrive - ppedv AG\\Anlagen\\Schulungsunterlagen\\C# Grundkurs\\C--Grundkurs-257864\\DemoTag4\\Lab11\\Personen.json");
		List<Person> personen = JsonSerializer.Deserialize<List<Person>>(readJson)!;
		#endregion

		//Hier eigenen Code schreiben
		List<Person> ergebnisPersonen;
		ergebnisPersonen = personen.Where(e => e.Alter >= 60).ToList();
		ergebnisPersonen = personen.Where(e => e.Job.Gehalt > 5000).ToList();
		ergebnisPersonen = personen.OrderBy(e => e.Job.Titel).OrderBy(e=> e.Job.Gehalt).ToList();
		int anzahlPersonen = personen.Count(e => e.Vorname.Length > 10);
		double avgGehaltSWE = personen.Where(e => e.Job.Titel =="Softwareentwickler").Average(e=> e.Job.Gehalt);
		anzahlPersonen = personen.Count(e => e.Hobbies.Count == 2);
		bool ergebnisBool = personen.Where(e => e.Alter > 50).All(e => e.Job.Gehalt * 12 > 25000);
		ergebnisPersonen = personen.Where(e=> e.Hobbies.Contains("Radfahren") && e.Hobbies.Contains("Laufen")).ToList();
		ergebnisPersonen = personen.Where(e => e.Nachname.StartsWith("S") && e.Vorname.StartsWith("M")).ToList();
		ergebnisPersonen = personen.Where(e=> e.Vorname.StartsWith(e.Nachname[0])).ToList();
		//Seite 2
		double durchschnittsAlter = personen.Average(e => e.Alter);
		ergebnisPersonen = personen.Where(e => e.Alter > durchschnittsAlter).ToList();
		ergebnisPersonen = personen.Where(e => e.Alter > 60 && (e.Hobbies.Contains("Laufen") ||
								e.Hobbies.Contains("Radfahren") ||
								e.Hobbies.Contains("Ballsport") ||
								e.Hobbies.Contains("Fitness"))).ToList();
		ergebnisPersonen = personen.Where(e => e.Alter > 60).Where(e=>e.Hobbies.Contains("Laufen") ||
								e.Hobbies.Contains("Radfahren") ||
								e.Hobbies.Contains("Ballsport") ||
								e.Hobbies.Contains("Fitness")).ToList();
		int anzahlJobs = personen.Select(e=> e.Job.Titel).Distinct().Count();
		int maxGehaltTischler = personen.Where(e => e.Job.Titel == "Tischler").Max(e => e.Job.Gehalt);
		ergebnisPersonen = personen.Where(e=>e.Geburtsdatum.Year == 1977).ToList();
		personen.Select(e=>e.Vorname+" "+e.Nachname).OrderBy(e=> e.Length).ToList();
		ergebnisPersonen = personen.OrderByDescending(e => e.Job.Gehalt).Take(5).ToList();
		ergebnisPersonen = personen.Where(e=> e.Job.Einstellungsdatum< new DateTime(2005,11,28)).ToList();
		personen.GroupBy(e => e.Vorname).ToDictionary(e => e.Key, e => e.Count()).OrderByDescending(e => e.Value).ToDictionary();
		personen.GroupBy(e => e.Job.Titel).ToDictionary(e => e.Key, e => e.Max(p => p.Job.Gehalt)).OrderBy(e => e.Key).ToDictionary();
		Console.WriteLine(personen.SelectMany(e => e.Hobbies).GroupBy(e => e).ToDictionary(e => e.Key, e => e.Count()).MaxBy(e=>e.Value));
		personen.GroupBy(e => e.Job.Titel).ToDictionary(e => e.Key, e => e.OrderByDescending(x => x.Job.Gehalt).Take(3)).ToDictionary();
	}
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
	"Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////