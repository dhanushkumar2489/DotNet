using System;
using PatientModule;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSDemo
{
    enum role
    {
        patient,
        physician,
        nurse,
        admin
    }
    class User
    {
        public string firstName, lastName, DOB, emailId;
        public long phoneNo;
        public int id;
        
        public void ChangePassword() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hiiii");
            Console.Read();
        }
    }
}
