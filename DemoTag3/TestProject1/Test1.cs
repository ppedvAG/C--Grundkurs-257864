using TaschenrechnerZumTesten;

namespace TestProject1
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestBerechneAddiern()
		{
			for (int i = 0; i<100; i++)
			{
				Random random = new Random();
				double a = random.NextDouble() * 100-i;
				double b = random.NextDouble() * 100 - i;
				double result = Methoden.Berechne(a, b, Rechenoperation.Addition);
				Assert.AreEqual(a+b, result);
			}
			
		}

		[TestMethod]
		public void TestBerechneDivisonDurchNull()
		{
			Assert.ThrowsException<DivideByZeroException>(() => Methoden.Berechne(1.0, 0, Rechenoperation.Division));
		}



		[TestMethod]
		public void TestZahlEingabeFormatException()
		{
			Assert.ThrowsException<FormatException>(() => Methoden.ZahlEingabe("asdf", "asdf"));
		}
	}
}
