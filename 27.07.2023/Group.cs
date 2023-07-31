using System;
namespace _27._07._2023
{
	public class Group
	{
		string _no;
		public string No
		{
			get
			{
				return _no;
			}
			set
			{
				if (value.Length == 4)
				{
					_no = value;
				}
			}
		}

		
		public double AvgPoint;

		public Group(string no, double avgPoint)
		{
			No = no;
			AvgPoint = avgPoint;

		}

	}
}

