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
            for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }
        }
    }

}
