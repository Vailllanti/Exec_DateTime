using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1計算三天後_DVD_應歸還時間
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime threeDaysLater = today.AddDays(3);

			Console.WriteLine($"今天的日期為:{today:yyyy/MM/dd}");
			Console.WriteLine($"DVD應歸還時間為:{threeDaysLater:yyyy/MM/dd}");
		}
	}
}
