using System;

namespace AssetProject
{
	public class AssetBO
	{
		public string ValidateAsset(Asset asset)
		{
			if(asset.Cost > 1000 && asset.Cost < 10000)
				return "Asset Valid";
			else
				throw new InvalidCostException();
		}
	}

	public class InvalidCostException : Exception
	{
		public InvalidCostException(){}
	}
}