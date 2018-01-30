using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
	[TestFixture(Category = "Multiply")]
	public class MultiplyTest
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
			new object[] { -1, 1, -1},
			new object[] { -1, 0, 0},
			new object[] { 0, 1, 0},
			new object[] {123, 123, 123*123},
			new object[] {-0.456, 0.456, -0.456*0.456},
			new object[] {-9, -6, 54},
			new object[] {-9, 6, -54},
			new object[] {5.6, 5.6, 5.6*5.6 },
			new object[] {-2147483648, 2147483648, 4.611686018427388e+18 },
			new object[] {double.MinValue, double.MaxValue, double.MinValue*double.MaxValue },
		};
		
		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveMultiplyTests(double firstVal, double secVal, double result)
		{
			Assert.AreEqual(calc.Multiply(firstVal, secVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}
