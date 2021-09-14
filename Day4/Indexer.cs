using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    class IndexedClass
    {
        readonly int a;
        IndexedClass()
        {
            a = 10;a = 12;
        }
        private string[] names = new string[10];

        public static void Main(string args)
        {
            IndexedClass nameList = new IndexedClass();
            //syntactic sugar
            nameList[0] = "peanut";
        }
        public String this[int index]
        {
            get
            {
                return (index == 0 && index <= 9) ? names[index] : "";
            }
            set
            {
                if(index == 0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }
        public int this[string name] //indexer
        {
            get
            {
                int index =0;
                while(index<10)
                {
                    if(names[index]==name)
                    { return index; }
                    index++;
                }
                return index;
            }
        }
    }
}
