using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void paint(int ab)
        {
            for (int i = 0; i < ab; i++)
            {
                for (int j = ab-i; j > 0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.paint(20);
        }
    }

}
