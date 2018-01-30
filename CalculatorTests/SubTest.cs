using CSharpCalculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
	[TestFixture(Category = "Sub")]
	public class SubTest
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
			new object[] { 0, 0, 0},
			new object[] { -1, 1, -2},
			new object[] {123, 123, 0},
			new object[] {-0.456, 0.456, -0.912 },
			new object[] {-9, -6, -3},
			new object[] {5.6, 5.6, 11.2 },
			new object[] {-5.6, -5.6, 0 },
			new object[] {int.MinValue, int.MaxValue, -4294967295 },
			new object[] {double.MinValue, double.MinValue, 0 },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveSubTests(double firstVal, double secVal, double result)
		{
			Assert.AreEqual(calc.Add(firstVal, secVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}
