using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
	[TestFixture(Category = "IsPositive")]
	public class IsPositiveTest
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
			new object[] { -1, false},
			new object[] {123, true},
			new object[] {-0.456, false},
			new object[] {5.6,true },
			new object[] {int.MinValue, false},
			new object[] {double.MinValue, false },
			new object[] {int.MaxValue, true},
			new object[] {double.MaxValue, true },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void IsPositiveTests(double firstVal, bool result)
		{
			Assert.AreEqual(calc.isPositive(firstVal), result);
		}

		private static object[] negativeTestCases =
		{

			new object[] {0, false },
			new object[] {0, true }
		};

		[Test]
		[Category("Positive"), TestCaseSource("negativeTestCases")]
		public void IsPositiveTestZero(double firstVal, bool result)
		{
			Assert.AreNotEqual(calc.isPositive(firstVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}
