using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_10
{
    class Stack_Node<T>
    {
        public T value { get; set; }
        public Stack_Node<T> next { get; set; } = null;
    }
    public class MyStack<T>: Parent
    {
        private Stack_Node<T> Tail { get; set; } = new Stack_Node<T>();
        //Индекс последнего помещенного элемента
        public int Top()
        {
            int i = 0;
            Stack_Node<T> node = new Stack_Node<T>();
            node = Tail;
            while (node != null)
            {
                i++;
                node = node.next;
            }
            return i;
        }
        public void Add(T value)
        {
            if (Top() == 0)
            {
                Tail.value = value;
            }
            else
            {
                Stack_Node<T> node = new Stack_Node<T> { value = Tail.value, next = Tail.next };
                Tail.next = node;
                Tail.value = value;
            }
        }
        public T Delete()
        {
            T value = Tail.value;
            Tail = Tail.next;
            return value;
        }
        public void Print()
        {
            Stack_Node<T> node = new Stack_Node<T>();
            node = Tail;
            for (int i = 0; i < Top() - 1; i++)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
    }
}
