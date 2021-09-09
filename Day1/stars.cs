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
            for (int i = 0; i < 7; i++)
            {
                for (int j = 7 - i; j > 0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }

}
