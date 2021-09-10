using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public string name { get; set; }
    }
    class Program
    {
        public void class1()
        {
            byte b1 = 45;
            sbyte b2 = -45;

            int a1 = b1; //implicit type casting
            Object obj1 = new Object();
            User user1 = new User();
            obj1 = user1;
            Console.WriteLine(typeof(User));
            Console.WriteLine(user1 is User);
            Console.ReadLine();

            dynamic somedata = 10;
            Console.WriteLine(somedata is int);
            somedata = "rak";
            Console.WriteLine(somedata is string);
        }
        public int age { get; } = 10;
        private int privateProp = 90;
        float balance = 100.4F;

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
            Program obj = new Program();
            obj.class1();
        }
    }
}
