using System;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CollectionType<int>();
            calc.Sum(5, 5);
        }
    }

    class CollectionType<T> : Methods, IShow<T> where T : struct
    { 
        List<T> list = new List<T>();

        public void Add(T num)
        {
            list.Add(num);
        }

        public void Delete(T num)
        {
            list.Remove(num);
        }

        public void Show()
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
