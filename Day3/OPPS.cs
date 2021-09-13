using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Super Constructor");
        }
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class Triangle : Shape
    {
        string kind;
        static long DateofCreation;

        static Triangle()
        {
            DateofCreation = DateTime.Now.Ticks;
            Console.WriteLine("called once");
        }

        public Triangle(double Width1) : base()
        {
            //this.Width = Width;
            this.Width = Width1;
        }
        public Triangle(double Width1, double v2): this(Width1)
        {
            Height = v2;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            BasicsOfInhertance();
        }

        private static void BasicsOfInhertance()
        {
            new Shape(); // default Constructor
            Triangle t1 = new Triangle(12.3, 13.4); // object,reference
            Shape t2 = t1; // reference can be of super class
            // new Triangle(); //can't create objects through static constructors
            Console.WriteLine(t1 == t2);
            Triangle triangleWithWidth = new Triangle(50.7);
            Console.WriteLine(triangleWithWidth.Width);
        }
    }
}
