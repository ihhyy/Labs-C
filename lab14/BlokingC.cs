using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;

namespace lab15
{
    class BlokingC
    {
        BlockingCollection<int> bc = new BlockingCollection<int>();

        public void AddGoods(int[] goods)
        {
            foreach (var g in goods)
            {
                Thread.Sleep(g * 500);
                bc.Add(g);
                Console.WriteLine($"{g} is on the storage");
            }
        }

        public void BuyGoods(int amount)
        {
            while (amount >= 0)
            {
                Thread.Sleep(300);
                Console.WriteLine($"{bc.Take()} is been bought");
                amount--;
            }

            Console.WriteLine(123123);
        }
    }
}
