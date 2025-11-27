namespace Lab06
{
	public class Program
	{
		public static void Main()
		{
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				Fahrzeug f = new Fahrzeug($"Fahrzeug_{i + 1}", (int)(random.NextDouble()*300), random.NextDouble()*100000);
				Console.WriteLine(f.Info());
			}
			Console.WriteLine(Fahrzeug.GetFahrzeugAnzahl());


		}
	}
}
