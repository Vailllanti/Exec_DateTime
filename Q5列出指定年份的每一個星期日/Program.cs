using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5列出指定年份的每一個星期日
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入指定年分:");
			string inputYears = Console.ReadLine();
			DateTime firstDay = Convert.ToDateTime($"{inputYears}/01/01");
			DateTime lastDay = Convert.ToDateTime($"{inputYears}/12/31");
			DayOfWeek dayOfWeek = firstDay.DayOfWeek;
			int day = (int)dayOfWeek;
			const int daysOfaWeek = 7;
			int howManyDayToFirstSunday = daysOfaWeek - day;
			DateTime firstSunday = firstDay.AddDays(howManyDayToFirstSunday);


			for (DateTime i = firstSunday; i <= lastDay; i = i.AddDays(7))
			{
				Console.WriteLine(i.ToString("yyyy/MM/dd"));
			}

		}
	}
}
