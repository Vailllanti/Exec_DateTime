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
			//DateTime today = DateTime.Today;
			//int days = Convert.ToInt32(today.ToString("dd"));

			int days = DateTime.Today.Day;
			
			const int early = 11;
			const int mid = 21;

			string massage = string.Empty;
			
			if (days < early)
			{
				massage = "上旬";
			}
			else if (days < mid)
			{
				massage = "中旬";
			}
			else
			{
				massage = "下旬";
			}
			Console.WriteLine($"今日為此月的{massage}");

		}
	}
}
