using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUygulama
{
    class MyDictionary<T,J>
    {
        T[] keys;
        J[] values;
        T[] tempKeys;
        J[] tempValues;

        public MyDictionary()
        {
            keys = new T[0];
            values = new J[0];
        }

        public void Add(T key, J value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new T[keys.Length + 1];
            values = new J[values.Length + 1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine(key+" = "+value+" eklendi.");


        }
    }
}
