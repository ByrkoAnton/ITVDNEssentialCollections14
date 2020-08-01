using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Collection03
{
    class MyDictionary<TKey, TValue> : IEnumerable<TValue>, IEnumerator<TValue>
    {
        TKey[] keys;
        TValue[] values;
        private int position = -1;

        public int Size
        {
            get
            {
                if (keys == null)
                    return 0;
                return keys.Length;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < keys.Length)
                {
                    return keys[index] + " - " + values[index];

                }
                return "Попытка обращения за пределы массива.";
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (keys != null)
            {
                TKey[] newKeys = new TKey[keys.Length + 1];
                TValue[] newValues = new TValue[values.Length + 1];
                for (int i = 0; i < keys.Length; i++)
                {
                    newKeys[i] = keys[i];
                    newValues[i] = values[i];
                }

                newKeys[^1] = key;
                newValues[^1] = value;
                keys = newKeys;
                values = newValues;
            }
            else
            {
                keys = new[] { key };
                values = new TValue[] { value };
            }
        }

        public void AddByIdx(int index, TKey key, TValue value)
        {
            if (index >= 0 && index < keys.Length)
            {
                keys[index] = key;
                values[index] = value;
            }
            else
                Console.WriteLine("Попытка обращения за пределы массива.");
        }

        public IEnumerator<TValue> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position >= keys.Length - 1)
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

        public TValue Current => values[position];

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
