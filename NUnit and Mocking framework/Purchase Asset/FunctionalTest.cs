using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AssetProject
{
	[TestFixture]
	public class FunctionalTest
	{
		[TestCase]
		public void TestValidAsset()
		{
			var obj = new AssetBO();
			var obj1 = new Asset("A1", "C2", "M1", 1010);
			var result = obj.ValidateAsset(obj1);
			Assert.That(result, Is.EqualTo("Asset Valid"));
		}
		[TestCase]
		public void TestInValidAsset()
		{
			var obj = new AssetBO();
			var obj1 = new Asset("A1", "C2", "M1", 80);
			Assert.That(() => obj.ValidateAsset(obj1), Throws.TypeOf<InvalidCostException>());
		}
	}
}