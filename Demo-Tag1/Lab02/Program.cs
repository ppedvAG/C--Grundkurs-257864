public class Program
{
	public static void Main(string[] args)
	{
		int jahr;
		Console.WriteLine("Gib das Jahr ein:");
		jahr = int.Parse(Console.ReadLine());

		bool schaltjahr;

		if (jahr%4==0)
		{
			schaltjahr = true;
			if(jahr%100==0)
			{
				schaltjahr = false;
				if(jahr%400==0)
				{
					schaltjahr = true;
				}
			}
		} else
		{
			schaltjahr = false;
		}

			Console.WriteLine($"Ist {jahr}  ein Schaltjahr? {schaltjahr}");

		if(jahr%4==0 && jahr%100==0 && jahr %400==0)
		{
			schaltjahr = true;
		}
		else if(jahr%4==0 && jahr%100!=0)
		{
			schaltjahr = true;
		}
		else if (jahr%4==0 && jahr%100==0 && jahr %400!=0)
		{
			schaltjahr = false;
		}
		else
		{
			schaltjahr = false;
		}
			Console.WriteLine($"Ist {jahr}  ein Schaltjahr? {schaltjahr}");
	}
}