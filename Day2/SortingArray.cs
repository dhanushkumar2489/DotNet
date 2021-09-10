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
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Bear", "Elephant", "Goat" };
            Array.Sort(animals);
            foreach(var item in animals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Array.Sort(animals, 0, 3);
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Array.Reverse(animals);
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int[] numbers = { 2, 1, 4, 3 };
            String[] numberNames = { "two", "one", "four", "three" };

            Array.Sort(numbers, numberNames);

            Array.ForEach<int>(numbers, n => Console.WriteLine(n));
            Array.ForEach<string>(numberNames, s => Console.WriteLine(s));

        }
    }
}