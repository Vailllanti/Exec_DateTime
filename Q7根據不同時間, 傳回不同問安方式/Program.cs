using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7根據不同時間__傳回不同問安方式
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			DateTime today = DateTime.Today;
			DateTime noon = today.AddHours(12);
		    DateTime night = noon.AddHours(6);
			if (now<noon)
			{
				Console.WriteLine("早安");
			}
			else if(now<night)
			{
				Console.WriteLine("午安");
			}
			else
			{
				Console.WriteLine("晚安");
			}
		}
	}
}
