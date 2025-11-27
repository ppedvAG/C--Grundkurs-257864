using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaschenrechnerTest.MethodenTest;
namespace TaschenrechnerTest
{
	[TestClass]
	public class MethodenTest
	{
		[TestMethod]
		public void TestBerechneAddiern()
		{
			double result = Berechne(5.2, 3.2, Rechenoperation.Addition);
			Assert.AreEqual(8.4, result);
		}
	}
}
