using System;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
	[TestFixture(Category = "IsNegative")]
	public class IsNegativeTest	
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
			new object[] { -1, true},
			new object[] {123, false},
			new object[] {-0.456, true},
			new object[] {5.6,false },
			new object[] {int.MinValue, true},
			new object[] {double.MinValue, true },
			new object[] {int.MaxValue, false},
			new object[] {double.MaxValue, false },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void IsNegativeTests(double firstVal, bool result)
		{
			Assert.AreEqual(calc.isNegative(firstVal), result);
		}

		private static object[] negativeTestCases =
		{
			
			new object[] {0, false },
			new object[] {0, true }
		};

		[Test]
		[Category("Positive"), TestCaseSource("negativeTestCases")]
		public void IsNegativeTestZero(double firstVal, bool result)
		{
			Assert.AreNotEqual(calc.isNegative(firstVal), result);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}

	}
}
