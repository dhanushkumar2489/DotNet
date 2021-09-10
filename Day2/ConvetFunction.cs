using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = Convert.ToInt32(Console.ReadLine());
            int result = convertFunction(y);
            Console.WriteLine(result);
        }

        private static int convertFunction(int y)
        {
            int x = y * y + 2 * y + 1;
            return x;
        }
    }
}