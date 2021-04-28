using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace lab15
{
    class Generator
    {
        public static void Generate()
        {
            Stopwatch stopV = new Stopwatch();
            int num = 30;
            int[] array = new int[1000000];
            for(int q = 0; q < num; q++)
            {
                stopV.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    array[i] = 1;
                }
                Console.WriteLine(array.Length);
                stopV.Stop();
            }

            Console.WriteLine(stopV.Elapsed);
        }

        public static List<int> Generate2(int num)
        {

            var list = new List<int>();
            for (int q = 0; q < num; q++)
            {
                list.Add(1);
            }
            return list;
        }

        public static void Add(int num)
        {
            int res = 0;

            for(int i = 0; i < num; i++)
            {
                res += num * 5;
            }

            Console.WriteLine(res);
        }

        public static void Show()
        {
            int res = 0;

            for (int i = 0; i < 1000000; i++)
            {
                res += 5;
            }

            Console.WriteLine(res);
        }
    }
}
