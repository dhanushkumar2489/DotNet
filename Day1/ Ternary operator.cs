using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
		static void Main(string[] args)
        {
			int x = 10, y = 100;

			var result = x > y ? "x is greater than y" : "x is less than y";

			Console.WriteLine(result);
		}
	}

}
