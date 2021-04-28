using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    public interface IList<TKey, TValue>
    {
        public void Add(TKey key, TValue value);
        public void Remove(TKey key);
        public void Search(TKey key);
        public void Display();
    }
}
