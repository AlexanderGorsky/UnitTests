using CSharpCalculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
	[TestFixture(Category = "Add")]
	public class AddTest
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
			new object[] { -1, 1, 0},
			new object[] {123, 123, 246},
			new object[] {-0.456, 0.456, 0 },
			new object[] {-9, -6, -15},
			new object[] {5.6, 5.6, 11.2 },
			new object[] {int.MinValue, int.MaxValue, 0 },
			new object[] {double.MinValue, double.MaxValue, 0 },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveAddTests(double firstVal, double secVal, double result)
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
