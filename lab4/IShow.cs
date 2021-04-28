using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    interface IShow<T>
    {
        void Add(T num);
        void Show();
        void Delete(T num);
    }
}
