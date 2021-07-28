using System;
using System.Collections.Generic;
using System.Text;

namespace _1272021.Class1
{
    class count
    {
        public void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 1, 1, 2, 3, 4, 4, 5, 6 };
            SortedDictionary < int ,int> s= new SortedDictionary<int,int>();
            //sorted dictionary
            foreach(int i in a)
            {
                if(s.ContainsKey(i) )
                {
                    s[i]+=1;
                }
                else
                {
                    s[i] = 1;
                }
            }
            //display data
            foreach (int j in s.Keys)
            {
                Console.WriteLine(j + "-" + s[j]);
            }
            int x = 30;
            Console.WriteLine("from master");
        }
    }
}
