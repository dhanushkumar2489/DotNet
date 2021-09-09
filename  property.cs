using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
		public string myField = string.Empty;

		public MyClass() { }

		public void MyMethod(int parameter1, string parameter2)
		{
			Console.WriteLine("First parameter {0},Second parameter {1}", parameter1, parameter2);
		}

		public int MyAutoImplementedProperty { get; set; }

		private int myPropertyVar;

		public int MyProperty
		{
			get { return myPropertyVar; }
			set { myPropertyVar = value; }
		}

		static void Main(string[] args)
        {
			MyClass myObj = new MyClass();
			myObj.MyProperty = 100;
			Console.WriteLine(myObj.MyProperty);
		}
	}

}
