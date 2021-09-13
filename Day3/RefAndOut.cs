using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class RefAndOutDemo
    {
        public static void Main(string[] values)
        {
            //OutDemo();
            RefDemo();
            
        }

        private static void RefDemo()
        {
            string str1 = "Ram";
            SetValue(ref str1);
            Console.WriteLine(str1);
        }

        private static void SetValue(ref string str)
        {
            str ="Hiiii";
        }

        private static void OutDemo()
        {
            int result;
            float res;
            bool returnedValue = Add(out result, out res, 110);
            Console.WriteLine(result);
            Console.WriteLine(res);
            Console.WriteLine(returnedValue);
        }

        public static bool Add(out int a, out float b, int c)
        {
            b = 30;
            a = 20;
            a = a + a;
            return true;
        }
    }
}
