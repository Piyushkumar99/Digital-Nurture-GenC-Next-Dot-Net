using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppCore
{
	public class Program
	{
		public static Employee e1=null;
		
		public static Employee EnrollEmployee()
		{
			return new Employee(){Name = "Tom", Id = "A1234"};
		}
	}
	public class Employee
	{
		public string Name { get; set; }
		public string Id { get; set; }
	}
}