using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3取得本月一日
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string firstDayOfMonth = $"今日為{today:yyyy/MM/dd}，本月第一天為{today:yyyy/MM}/01";
			Console.WriteLine(firstDayOfMonth);
		}
	}
}
