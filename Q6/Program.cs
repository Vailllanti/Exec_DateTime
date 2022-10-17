using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int days = Convert.ToInt32(today.ToString("dd"));
			
			const int early = 11;
			const int mid = 21;
			
			if (days < early)
			{
				Console.WriteLine("今日為此月上旬");
			}
			else if (days < mid)
			{
				Console.WriteLine("今日為此月中旬");
			}
			else
			{
				Console.WriteLine("今日為此月下旬");
			}

		}
	}
}
