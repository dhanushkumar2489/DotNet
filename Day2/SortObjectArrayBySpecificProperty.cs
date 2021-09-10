using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Person)x).LastName, ((Person)y).LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person(){ FirstName="Steve", LastName="Jobs"},
                new Person(){ FirstName="Bill", LastName="Gates"},
                new Person(){ FirstName="Lary", LastName="Page"}
            };
            //Sort by FirstName
            Array.Sort(people, new PersonComparer());
            var qr = from p in people
                      orderby p.FirstName
                      select p;
            Array.ForEach<Person>(qr.ToArray<Person>(), p => Console.WriteLine(p.FirstName + " " + p.LastName));

            Console.WriteLine();
            //Sort by LasttName
            var qry = from p in people
                      orderby p.LastName
                      select p;

            Array.ForEach<Person>(qry.ToArray<Person>(), p => Console.WriteLine(p.FirstName + " " + p.LastName));
        }
    }
}