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
            while (true) 
            {
                Console.Write("Enter 'y' :");
                string y = Console.ReadLine();
                try
                {
                    if (y == "q") break;
                    int result = convertFunction(Convert.ToInt32(y));
                    Console.WriteLine(result);
                }
                catch
                {
                    Console.WriteLine("Give an Integer");
                }
            }
            
        }

        private static int convertFunction(int y)
        {
            int x = y * y + 2 * y + 1;
            return x;
        }
    }
}