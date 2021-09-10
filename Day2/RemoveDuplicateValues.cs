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
            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] dist = nums.Distinct().ToArray();
            foreach(var item in dist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
            string[] val = animals.Distinct().ToArray();
            foreach (var item in val)
            {
                Console.WriteLine(item);
            }

        }
    }
}