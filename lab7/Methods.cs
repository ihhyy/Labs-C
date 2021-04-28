using System;
using System.Collections.Generic;
using System.Text;

namespace lab8
{
    class Methods
    {
        private int result;


        public int Sum(int num1, int num2)
        {
            result = num1 + num2;
            return result;
        }

        public int Dif(int num1, int num2)
        {
            result = num1 - num2;
            return result;
        }
    }
}
