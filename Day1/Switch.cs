﻿using System;
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
			int x = 10;

			switch (x)
			{
				case 5:
					Console.WriteLine("Value of x is 5");
					break;
				case 10:
					Console.WriteLine("Value of x is 10");
					break;
				case 15:
					Console.WriteLine("Value of x is 15");
					break;
				default:
					Console.WriteLine("Unknown value");
					break;
			}
		}
    }

}
