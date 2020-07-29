using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection02
{
    class MyList<T>:IEnumerable<T>, IEnumerator<T>
    {
        T[] col;

        private int position = -1;

        public int Size
        {
            get
            {
                if (col == null)
                    return 0;
                return col.Length;
            }
        }

        public T this[int idx]
        {
            get
            {
                if (idx >= col.Length)
                {
                    Console.WriteLine($"No elem by this idx. Will return the last element in position [{col.Length-1}]");
                    return col[^1];
                }
                return col[idx];
            }
        }

        public void Add(T elem)
        {
            if (col != null)
            {
                T[] newCol = new T[col.Length+1];
                for (int i = 0; i < col.Length; i++)
                {
                    newCol[i] = col[i];
                }

                newCol[^1] = elem;
                col = newCol;
            }
            else
            {
                col = new T[] {elem};
            }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position >= col.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return true;
        }

        public void Reset()
        {
            position = -1;
        }

        public T Current => col[position];

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
