using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace DemoAppCore
{
	[TestFixture]
	class FunctionalTest
	{
		[Test]
		public void Return_String()
		{
			var program = new Program();
			var result = Program.FinalMessage();
			StringAssert.Contains(result, "The total is Rs.7600");
		}
	}
}