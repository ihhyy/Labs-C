using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    public interface Ilists<T> where T : Cars<int, string>
    {
        public void Add(T Cars);
        public void Remove(T Cars);
        public void Search(T Cars);
        public void Display();
    }
}
