using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_10
{
    public class Instruments<T>
    {
        public Hash hash { get; set; }
        public MyList<int> myList { get; set; }
        public MyStack<int> stack { get; set; }
        public Instruments()
        {
            hash = new Hash(100);
            myList = new MyList<int>();
            stack = new MyStack<int>();
        }
        void Add()
        {
            hash.Add(1);
            myList.Add(2);
            stack.Add(3);
        }
    }
}
