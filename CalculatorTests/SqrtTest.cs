using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
	[TestFixture(Category = "Sqrt")]
	public class SqrtTest
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
			new object[] { 0, Math.Sqrt(0)},
			new object[] { -1, Math.Sqrt(-1)},
			new object[] {123, Math.Sqrt(123)},
			new object[] {-0.456, Math.Sqrt(-0.456)},
			new object[] {-9, Math.Sqrt(-9)},
			new object[] {5.6, Math.Sqrt(5.6)},
			new object[] {int.MinValue,  Math.Sqrt(int.MinValue)},
			new object[] {double.MinValue,Math.Sqrt(double.MinValue)},
			new object[] {int.MaxValue,  Math.Sqrt(int.MaxValue)},
			new object[] {double.MaxValue,Math.Sqrt(double.MaxValue)},
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveSqrtTests(double firstVal, double result)
		{
			Assert.AreEqual(calc.Sqrt(firstVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}
