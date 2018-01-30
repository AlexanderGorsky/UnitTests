using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
	[TestFixture(Category = "Pow")]
	public class PowTest
	{
		private Calculator calc;

		[SetUp]
		public void SetUp()
		{
			Console.WriteLine("NUnit test(s) are started");
		}

		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			calc = new Calculator();
		}

		private static object[] positiveTestCases =
		{
			new object[] { -1, 1, Math.Pow(-1, 1)},
			new object[] { -1, 0, Math.Pow(-1, 0)},
			new object[] { 0, 1, Math.Pow(0, 1)},
			new object[] {123, 123, Math.Pow(123, 123)},
			new object[] {-0.456, 0.456, Math.Pow(-0.456, 0.456)},
			new object[] {-9, -6, Math.Pow(-9, -6)},
			new object[] {-9, 6, Math.Pow(-9, 6)},
			new object[] {5.6, 5.6, Math.Pow(5.6, 5.6) },
			new object[] {double.MinValue, double.MaxValue, Math.Pow(double.MinValue, double.MaxValue) },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositivePowTests(double firstVal, double secVal, double result)
		{
			Assert.AreEqual(calc.Pow(firstVal, secVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}
