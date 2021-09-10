using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] arr = { 1, 2, 3, 4, 5 };
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //ArrayList
            ArrayList arList = new ArrayList();
            arList.Add(1);
            arList.Add("Two");
            arList.Add(false);
            foreach (var item in arList)
            {
                Console.WriteLine(item);
            }
        }
    }
}