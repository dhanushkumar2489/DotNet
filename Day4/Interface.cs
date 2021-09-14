using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    interface IUser
    {
        int a { get; set; }
        void work();
    }
    class Class1 : IUser
    {
        public int a { get => a; set => a = value; }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
