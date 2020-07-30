using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection02
{
    public static class ClassExtensionT04
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] arr = list.ToArray();
            return arr;
        }
        
    }
}
