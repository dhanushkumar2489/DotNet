using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            takeInputFromConsole();
        }

        private static void takeInputFromConsole()
        {
            //int x, y;
            // x = Convert.ToInt32(Console.ReadLine());
            // y = Convert.ToInt32(Console.ReadLine());
            //string a, b;
            //a = Console.ReadLine();
            //b = Console.ReadLine();
            //int x =int.Parse(a);
            //int y = int.Parse(b);
            //Console.WriteLine(x + y);

            string val = null;
            int result;
            bool ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(ifSuccess);
        }
    }
}
