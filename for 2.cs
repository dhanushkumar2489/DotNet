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
            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i: {0}", d);
            }
        }
    }

}
