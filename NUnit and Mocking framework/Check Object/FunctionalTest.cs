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
		public void Check_For_Null()
		{
			Assert.Null(Program.e1);
		}
		[Test]
		public void Check_For_obj_Null()
		{
			Assert.IsNotNull(Program.EnrollEmployee());
		}
		[Test]
		public void Check_For_Name()
		{
			var result = Program.EnrollEmployee();
			Assert.AreEqual("Tom", result.Name);
		}
		[Test]
		public void Check_For_Id()
		{
			var result = Program.EnrollEmployee();
			Assert.AreEqual("A1234", result.Id);
		}
	}
}