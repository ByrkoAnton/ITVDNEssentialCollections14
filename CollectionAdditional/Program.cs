using System;
using System.Collections;

namespace CollectionAdditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var b = GetEvens(a);

            foreach (var i in a)
            {
                Console.Write(i +" ");
            }

            Console.WriteLine();

            foreach (var i in b)
            {
                Console.Write(i + " ");
            }
        }

        public static  IEnumerable GetEvens(int[] arr)
        {
            foreach (var i in arr)
            {
                if (i % 2 == 0)
                    yield return i;
            }
        }
    } 
    
}
