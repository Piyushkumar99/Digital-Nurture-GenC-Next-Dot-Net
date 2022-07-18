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
		public void FailCase()
		{
			var result = Program.CalculateGrade(20);
			Assert.That(result, Is.EqualTo("FAIL"));
		}
		[Test]
		public void PassCase()
		{
			var result = Program.CalculateGrade(60);
			Assert.That(result, Is.EqualTo("PASS"));
		}
	}
}