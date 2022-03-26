using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_10
{
    public class Hash: Parent
    {
        private MyList<int>[] Table;
        public Hash(int size)
        {
            Count = size;
            Table = new MyList<int>[Count];
        }

        public void Add(int info)
        {
            int index = info % Count;
            if (Table[index] == null)
            {
                Table[index] = new MyList<int>();
            }
            Table[index].Add(info);
        }

        public string Find(int index)
        {
            string res = " ";
            for (int i = 0; i < Count; i++)
            {
                if (index % Count == i)
                {
                    Node<int> curr = Table[i].Head;
                    do
                    {
                        if (curr.value == index)
                        {
                            res += Convert.ToString(curr.value) + "\n";
                        }
                        curr = curr.next;
                    } while (curr != null);
                }
            }
            return res;
        }

        public string ToString()
        {
            string res = "{ \n";
            for (int i = 0; i < Count; i++)
            {
                if (Table[i] != null)
                {
                    Node<int> curr = Table[i].Head;
                    while (curr != null)
                    {
                        res += Convert.ToString(curr.value) + "\n";
                        curr = curr.next;
                    }
                }
            }
            res += "}";
            return res;
        }
        public void Delete(int index)
        {
            int hash = index % Count;
            MyList<int> list = Table[hash];
            list.DeleteByIndex(list.Head, index);
        }
        public void Clear(int index)
        {
            MyList<int> list = Table[index];
            list.Clear();
        }
    }
}
