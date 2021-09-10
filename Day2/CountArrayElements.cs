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
            string[] empty = new string[5];
            var totalElements = empty.Count();
            Console.WriteLine(totalElements);

            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            totalElements = animals.Count();
            Console.WriteLine(totalElements);

            var totalCats = animals.Count(s => s == "Cat");
            Console.WriteLine(totalCats);

            var animalsStartsWithA = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(animalsStartsWithA);

            var animalsWithCapitalLetter = animals.Count(s =>
            {
                return Regex.IsMatch(s, "^[A-Z]");
            });
            Console.WriteLine(animalsWithCapitalLetter);


            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
            totalElements = nums.Count();
            Console.WriteLine(totalElements);

            var totalEvenNums = nums.Count(n => n % 2 == 0);
            Console.WriteLine(totalEvenNums);

        }
    }
}