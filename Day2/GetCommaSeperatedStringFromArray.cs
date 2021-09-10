using System;
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
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey" };
            var str = String.Join(",", animals);
            Console.WriteLine(str);

            int[] nums = { 1, 2, 3, 4 };
            var val = String.Join(",", nums);
            Console.WriteLine(val);

        }
    }
}