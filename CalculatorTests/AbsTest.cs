using System;
using System.Text;
using System.Collections.Generic;
using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
	
	[TestFixture(Category = "Abs")]
	class AbsTest
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
			new object[] { 0, 0},
			new object[] { -1, 1},
			new object[] {123,123},
			new object[] {-0.456, 0.456 },
			new object[] {int.MinValue, int.MaxValue },
			new object[] {double.MinValue, double.MaxValue },
			new object[] {-5.6, 5.6 },
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveAbsTests(double initValue, double expectedValue)
		{
			Assert.AreEqual(calc.Abs(initValue), expectedValue);
		}

		private static object[] negativeTestCases =
		{
			new object[] { -1, -1},
			new object[] {123, -123},
			new object[] {-0.456, -0.456 },
			new object[] {int.MaxValue, int.MinValue },
			new object[] {"-5.6", 5.6 },
		};

		[Test]
		[Category("Negative"), TestCaseSource("negativeTestCases")]
		public void NegativeAbsTests(double initValue, double expectedValue)
		{
			Assert.AreNotEqual(calc.Abs(initValue), expectedValue);
		}

		[TearDown]
		public void CleanUp()
		{
			Console.WriteLine("NUnit test(s) are complete");
		}
	}
}
