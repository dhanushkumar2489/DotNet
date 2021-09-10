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
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
            string[] birds = { "Sparrow", "Peacock", "Dove", "Crow" };

            var all = animals.Union(birds).ToArray();
            foreach( var item in all)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] num2 = { 55, 23, 45, 50, 80 };

            var alNumb = num1.Union(num2).ToArray();
            foreach (var item in alNumb)
            {
                Console.WriteLine(item);
            }

        }
    }
}