using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_10
{
    public class Node<T>
    {
        public T value { get; set; }
        public Node<T> next { get; set; }
    }
    public class MyList<T>: Parent
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public void Add(T value)
        {
            Node<T> node = new Node<T> { value = value };

            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }

            Count++;
        }
        public void Delete(T value)
        {
            Node<T> node = new Node<T>();
            Node<T> prev = new Node<T>();
            prev = Head;
            node = Head;
            for (int i = 0; i < Count; i++)
            {
                if (Equals(node.value, value))
                {
                    if (Head == node)
                        Head = node.next;
                    else
                        prev.next = node.next;
                    Count--;
                }
                else
                    if (node != prev)
                    prev = prev.next;
                node = node.next;
            }
        }
        public void DeleteByIndex(Node<int> head, int index)
        {
            Node<int> past = head, curr = head;
            do
            {
                if (index == curr.value)
                {
                    if (curr == head)
                    {
                        Head = Head.next;
                    }
                    else
                    {
                        past.next = past.next.next;
                    }
                    Count--;
                }
                if (curr != head)
                {
                    past = past.next;
                }
                curr = curr.next;
            } while (curr != null);
        }
        public void Print()
        {
            Node<T> node = new Node<T>();
            node = Head;
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }
}
