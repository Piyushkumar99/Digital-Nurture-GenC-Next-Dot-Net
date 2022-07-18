using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DemoAppCore
{
	public class Program
	{
		public static string CalculateGrade(float mark)
		{
			string grade = "";
			if(mark < 40)
				grade="FAIL";
			else if(mark >= 40)
				grade="PASS";
			return grade;
		}
	}
}