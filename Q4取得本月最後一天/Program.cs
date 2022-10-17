using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4取得本月最後一天
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//今日
			DateTime today = DateTime.Today;
			//本月第一天
		    DateTime firstDayOfTheMonth = Convert.ToDateTime($"{today:yyyy/MM}/01");
			//下個月第一天
			DateTime nextMonth = firstDayOfTheMonth.AddMonths(1);
			//本月最後一天
			DateTime lastDayOfTheMonth = nextMonth.AddDays(-1);

			Console.WriteLine($"今日為{today:yyyy/MM/dd}，本月的最後一天為{lastDayOfTheMonth:yyyy/MM/dd}");

		}
	}
}
