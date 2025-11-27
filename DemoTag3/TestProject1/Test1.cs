using TaschenrechnerZumTesten;

namespace TestProject1
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestBerechneAddiern()
		{
			double result = Methoden.Berechne(5.2, 3.2, Rechenoperation.Addition);
			Assert.AreEqual(8.4, result);
		}

		[TestMethod]
		public void TestZahlEingabeFormatException()
		{
			Assert.ThrowsException<FormatException>(() => Methoden.ZahlEingabe("asdf", "asdf"));
		}
	}
}
