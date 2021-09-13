using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    enum role
    {
        Delivery_Manager=1,developer
    }

    class User
    {
        public const int age = 18; // instance Constant
        public role role;
        public User(string name)
        {
            const int age = 28;   // Local Constant+1
            Console.WriteLine("Age is {0}",age);
            this.name = name;
        }
        public static int count;

        static User()
        {
            Console.WriteLine("static Called");
        }

        public string name { get; } // read only
        public virtual void Enter()
        {
            Console.WriteLine("1");
        }
    }

    class Employee :User
    {
        public Employee(string name) :base(name)
        {

        }
        public new void Enter()  // overriding
        {
            Console.WriteLine("2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(User.count);
            Demo1();

        }

        private static void Demo1()
        {
            Employee e1 = new Employee("Ram");
            e1.role = role.Delivery_Manager;
            Console.WriteLine((int)e1.role);
            string strRole = role.Delivery_Manager.ToString();
            Console.WriteLine(strRole);
            e1.Enter();
            Console.WriteLine(e1.name);

            //User u1 = new User();
            //u1.Enter();
        }
    }
}
