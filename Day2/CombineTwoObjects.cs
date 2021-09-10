using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    class Person : IEquatable<Person>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            return FirstName.Equals(other.FirstName) && LastName.Equals(other.LastName);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ (FirstName == null ? 0 : FirstName.GetHashCode()) ^ (LastName == null ? 0 : LastName.GetHashCode());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people1 = 
            {
                new Person(){ FirstName="Steve", LastName="Jobs"},
                new Person(){ FirstName="Bill", LastName="Gates"},
                new Person(){ FirstName="Steve", LastName="Jobs"},
                new Person(){ FirstName="Lary", LastName="Page"}
            };

            Person[] people2 = 
            {
                new Person(){ FirstName="Steve", LastName="Jobs"},
                new Person(){ FirstName="Lary", LastName="Page"},
                new Person(){ FirstName="Bill", LastName="Gates"}
            };

            var allp = people1.Union(people2).ToArray();
            Array.ForEach(allp, p => Console.WriteLine(p.FirstName));

        }
    }
}