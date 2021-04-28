using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace lab15
{
    class Methods
    {
        public List<int> list;
        public int num;

        public Methods(int _num)
        {
            list = new List<int>();
            num = _num;

            for(int i = 2; i < _num; i++)
            {
                list.Add(i);
            }
        }

        public  void Sort(CancellationToken token)
        {
            Stopwatch stopV = new Stopwatch();

            stopV.Start();
            Console.WriteLine("calculating");

            if (token.IsCancellationRequested)
            {
                Console.WriteLine("canceled");
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                for(int j = 2; j < num; j++)
                {
                    list.Remove(list[i] * j);
                }
            }

            Console.WriteLine("done");
            TimeSpan ts = stopV.Elapsed;
            Console.WriteLine($"{list.Count} {ts}");

            stopV.Stop();
        }

    }
}
