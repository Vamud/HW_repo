using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>() { 1, 3, 4};
            list.AddItem(11);
            list.AddItem(12);
            list.AddItem(13);
            list.AddRange(new List<int> { 1, 5, 3, 9});
            foreach(int i in list)
                Console.WriteLine(i);

            list.Remove(12);
            list.RemoveAt(0);
            list.Sort();
            foreach (int i in list)
                Console.WriteLine(i);
        }
    }
}