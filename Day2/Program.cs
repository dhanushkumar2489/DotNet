using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public void class1()
        {
            byte b1 = 45;
            sbyte b2 = -45;

            int a1 = b1; //implicit type casting
            

            dynamic somedata = 10;
            Console.WriteLine(somedata is int);
            somedata = "rak";
            Console.WriteLine(somedata is string);
            somedata = b2;
            Console.ReadLine();
        }
        public int age { get; } = 10;
        private int privateProp = 90;

        public int publicName
        {
            get { return privateProp; }
            set { if (value != 90)
                    Console.WriteLine();
                else
                    privateProp = value;
            }

        }
        static void Main(string[] args)
        {
            takeInputFromConsole();
            var name = "Welcome";
            var a = 34;
            Console.WriteLine("name = {0}, a= {1}", name, a);
            Console.ReadLine();

            Program obj = new Program();
            obj.class1();

            ArrayDemo();
        }

        private static void takeInputFromConsole()
        {
            int y;
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y);
            Console.Read();
        }

        private static void ArrayDemo()
        {
            int[] array = { 1, 2, 4, 6, 8, 9, 11, 14, 16 };
            var a = from i in array where i % 2 == 0 select i;
            foreach (var _a in a)
            {
                Console.WriteLine("{0}\n", _a);
            }
            Console.ReadLine();
        }
    }
}
