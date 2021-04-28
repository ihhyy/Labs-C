using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    static class Formula
    {
        public static double Comp1(int a, int b)
        {
            return (a + b) / 4;
        }

        public static double Comp2(int a)
        {
            return Math.Sqrt(a);
        }

        public static double Comp3(int a)
        {
            return Math.Log2(a);
        }

        public static void Form(double res1, double res2, double res3)
        {
            Console.WriteLine(res1 + res2 + res3);
        }

        public static void ContEx(Task t)
        {
            Console.WriteLine(12345);
        }

    }
}
