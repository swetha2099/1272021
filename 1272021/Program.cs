using System;
using System.Collections;
using System.Collections.Generic;

namespace _1272021
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push("Hello");
            st.Push(3.4f);

            st.Pop();
            st.Pop();
            Console.WriteLine(st.Peek());

            foreach (object o in st)
            {
                Console.WriteLine(o);
            }

            Stack<int> st2 = new Stack<int>();
            st2.Push(3);
            st2.Push(4);

            //Queue q = new Queue();
            //q.Enqueue("Hello");
            //q.Enqueue("World");
            //q.Enqueue("Hi");
            //q.Dequeue();

            //foreach (string j in q)
            //{
            //    Console.WriteLine(j);
            //}

            Queue<string> q = new Queue<string>();
            q.Enqueue("Hello");
            q.Enqueue("World");
            q.Enqueue("Hi");
            q.Dequeue();

            foreach (string i in q)
            {
                Console.WriteLine(i);
            }
            //modification
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(21, "Orange");
            d.Add(24, "Guava");
            d.Add(13, "Mango");
            d.Add(45, "Apple");
            //iterating by keys
            foreach (int i in d.Keys)
            {
                Console.WriteLine(i + " - " + d[i]);
            }

            SortedDictionary<int, string> d1 = new SortedDictionary<int, string>();
            d1.Add(51, "Orange");
            d1.Add(22, "Guava");
            d1.Add(3, "Mango");
            d1.Add(14, "Apple");
            foreach (int i in d1.Keys)
            {
                Console.WriteLine(i + " - " + d1[i]);
            }





        }
    }
}
