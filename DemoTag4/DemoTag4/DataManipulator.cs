using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DemoTag4
{
	internal class DataManipulator
	{
		// Methode zum Einlesen einer CSV-Datei und Rückgabe eines Dictionary
		public static Dictionary<string, string[]> ReadCsv(string filePath)
		{
			if(!File.Exists(filePath))
			{
				throw new FileNotFoundException("Die angegebene Datei wurde nicht gefunden.", filePath);
			}


			using (StreamReader sr = new StreamReader(filePath))
			{
				sr.ReadLine(); // Überschriftenzeile überspringen
				Dictionary<string, string[]> data = new Dictionary<string, string[]>();
				while (!sr.EndOfStream)
				{
					// ganze Zeile einlesen
					string line = sr.ReadLine();
					
					if (string.IsNullOrWhiteSpace(line))
						continue; // Leere Zeilen überspringen

					string[] cells = line.Split(','); // Zellen trennen

					string key = cells[0]; // Erste Zelle als Schlüssel verwenden
										   
					string[] values = cells.Skip(1).ToArray(); // Restliche Zellen als Werte verwenden

					// konvertierte Daten der Zeile als Eintrag im Dictionary speichern
					data.Add(key, values);

				}
				// fertiges Dictionary zurückgeben
				return data;
			}
		}

		// Methode zum Speichern eines Dictionary in eine Json Datei
		public static void SaveToJson<T>(string filePath, Dictionary<string, T> data)
		{
			string jsonString = JsonSerializer.Serialize(data);
			// alte, längere Variante
			//using(StreamWriter sw = new StreamWriter(filePath))
			//{
			//	sw.Write(jsonString);
			//}
			// kürzere Variante zum Schreiben in eine Datei von einem String
			File.WriteAllText(filePath, jsonString);
		}
	}
}
