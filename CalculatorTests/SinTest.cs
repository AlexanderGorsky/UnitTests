using CSharpCalculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
	[TestFixture(Category = "Cos")]
	public class SinTest
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
			new object[] { 0, Math.Sin(0)},
			new object[] { -1, Math.Sin(-1)},
			new object[] { 1, Math.Sin(1)},
			new object[] {123, Math.Sin(123)},
			new object[] {-123, Math.Sin(-123)},
			new object[] {-0.456, Math.Sin(-0.456)},
			new object[] {5.6, Math.Sin(5.6)},
			new object[] {int.MinValue,  Math.Sin(int.MinValue) },
			new object[] {double.MinValue,Math.Sin(double.MinValue)},
			new object[] {int.MaxValue,  Math.Sin(int.MaxValue) },
			new object[] {double.MaxValue,Math.Sin(double.MaxValue) },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveSinTests(double initVal, double result)
		{
			Assert.AreEqual(calc.Sin(initVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}

