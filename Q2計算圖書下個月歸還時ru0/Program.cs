using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2計算圖書下個月歸還時間
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime returnTime = today.AddMonths(1);

			Console.WriteLine($"借閱時間:{today:yyyy/MM/dd}");
			Console.WriteLine($"應歸還日期:{returnTime:yyyy/MM/dd}");
		}
	}
}
