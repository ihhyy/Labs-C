using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace lab11
{
    class Vector
    {
        public int[] arr;
        public bool status;
        public int length;

        public Vector(int[] _arr, bool _status, int _length)
        {
            arr = _arr;
            status = _status;
            length = _length;
        }
    }
}
