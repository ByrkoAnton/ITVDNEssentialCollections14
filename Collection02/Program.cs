using System;

namespace Collection02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            Console.WriteLine(list.Size);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            Console.WriteLine(list.Size);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.Size);

            Console.WriteLine(list[4]);
            Console.WriteLine("--04--");
            var arr = list.GetArray();

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
