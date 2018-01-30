using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
	[TestFixture(Category = "Divide")]
	public class DivideTest
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
			new object[] { -1, 1, -1/1},
			new object[] {123, 123, 123/123},
			new object[] {-0.456, 0.456, -0.456/0.456},
			new object[] {-9, -6, 1.5},
			new object[] {-9, 6, -1.5},
			new object[] {5.6, 5.6, 5.6/5.6 },
			new object[] {int.MinValue, int.MaxValue, int.MinValue/int.MaxValue},
			new object[] {double.MinValue, double.MaxValue, double.MinValue/double.MaxValue },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveDivideTests(double firstVal, double secVal, double result)
		{
			Assert.AreEqual(calc.Add(firstVal, secVal), result);
		}
				
		[Test]
		public void NegativeDivideTests()
		{
			Assert.Throws<DivideByZeroException>(new TestDelegate(() => DivideByZero()));
		}

		private void DivideByZero()
		{
			var a = (1 / Double.Parse("0"));
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}
