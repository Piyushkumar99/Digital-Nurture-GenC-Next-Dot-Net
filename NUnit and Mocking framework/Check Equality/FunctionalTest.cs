using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DemoAppCore
{
	[TestFixture]
	public class FunctionalTest
	{
		[Test]
		public void Test_AddMethod()
		{
			int res = Program.AddNumbers(10, 10);
			Assert.AreEqual(res, 20);
		}
		[Test]
		public void Test_SubMethod()
		{
			int res = Program.SubNumbers(10, 10);
			Assert.AreEqual(res, 0);
		}
		[Test]
		public void Test_MultMethod()
		{
			int res = Program.MulNumbers(10, 10);
			Assert.AreEqual(res, 100);
		}
		[Test]
		public void Test_DivideMethod()
		{
			int res = Program.DivNumbers(10, 10);
			Assert.AreEqual(res, 1);
		}
	}
}