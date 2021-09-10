using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Find literal value
            string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
            var stringToFind = "Bill";

            var result = Array.Find(names, element => element == stringToFind);
            Console.WriteLine(result);

            Console.WriteLine("-----------------------------");

            //2. Find elements that starts with B
            result = Array.Find(names, element => element.StartsWith("B"));
            Console.WriteLine(result);

            Console.WriteLine("-----------------------------");

            //3.Find by length
            result = Array.Find(names, element => element.Length >= 5);
            Console.WriteLine(result);

            Console.WriteLine("-----------------------------");

            //4.Find All literal values 
            string[] val = Array.FindAll(names, element => element.ToLower() == stringToFind);
            foreach (var item in val)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            //5.Find all elements starting with B
            val = Array.FindAll(names, element => element.StartsWith("B"));
            foreach (var item in val)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            //6. Find All elements by length
            val = Array.FindAll(names, element => element.Length >= 5);
            foreach (var item in val)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            //7.Find last element
            var res = Array.FindLast(names, element => element.Contains(stringToFind));
            Console.WriteLine(res);

            Console.WriteLine("-----------------------------");

            //8. Find last element starting with B
            res = Array.FindLast(names, element => element.StartsWith("B"));
            Console.WriteLine(res);

            Console.WriteLine("-----------------------------");

            //9.Find last element by length
            res = Array.FindLast(names, element => element.Length >= 5);
            Console.WriteLine(res);
        }
    }
}
