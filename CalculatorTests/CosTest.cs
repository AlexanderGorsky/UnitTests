using CSharpCalculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
	[TestFixture(Category = "Cos")]
	public class CosTest
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
			new object[] { 0, Math.Cos(0)},
			new object[] { -1, Math.Cos(-1)},
			new object[] {123, Math.Cos(123)},
			new object[] {-0.456, Math.Cos(-0.456)},
			new object[] {-9, Math.Cos(-9)},
			new object[] {5.6, Math.Cos(5.6)},
			new object[] {int.MinValue,  Math.Cos(int.MinValue) },
			new object[] {double.MinValue,Math.Cos(double.MinValue)},
			new object[] {int.MaxValue,  Math.Cos(int.MaxValue) },
			new object[] {double.MaxValue,Math.Cos(double.MaxValue) },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveCosTests(double initVal, double result)
		{
			Assert.AreEqual(calc.Cos(initVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}

