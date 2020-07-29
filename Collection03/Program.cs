using System;
using System.Collections;

namespace Collection03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            Console.WriteLine(myDictionary.Size);
            myDictionary.Add(1, "a");
            myDictionary.Add(2, "b");
            myDictionary.Add(3, "c");
            myDictionary.Add(4, "d");
            Console.WriteLine(myDictionary.Size);

            foreach(var i in myDictionary)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(myDictionary[0]);

        }
    }
}
