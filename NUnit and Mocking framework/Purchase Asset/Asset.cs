using System;

namespace AssetProject
{
	public class Asset
	{
		private string _name;
		private string _category;
		private string _model;
		private double _cost;

		public string Name{ get; set; }
		public string Category{ get; set; }
		public string Model{ get; set; }
		public double Cost{ get; set; }

		public Asset(){}
		public Asset(string name, string category, string model, double cost)
		{
			_name=name;
			_category=category;
			_model=model;
			_cost=cost;
		}
	}
}