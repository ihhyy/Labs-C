using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace lab15
{
    class Program
    {
        //public delegate void G1();
        static void Main()
        {
            //G1 g1 = Generator.Generate;
            //Parallel.Invoke(Generator.Show, 
            //    delegate() {
            //        int num = 30;
            //        int[] array = new int[1000000];
            //        for (int q = 0; q < num; q++)
            //        {
            //            for (int i = 0; i < 1000000; i++)
            //            {
            //                array[i] = 1;
            //            }
            //            Console.WriteLine(array.Length);
            //        }
            //    });
            //var m = new Methods(10000);
            //CancellationTokenSource ct = new CancellationTokenSource();
            //CancellationToken token = ct.Token;
            //Task task = new Task(() => m.Sort(token));
            //task.Start();


            //string message = Console.ReadLine();

            //if (message == "C")
            //{
            //    ct.Cancel();
            //    return;
            //} 

            //var task1 = new Task<double>(() => Formula.Comp1(3, 5));
            //var task2 = new Task<double>(() => Formula.Comp2(3));
            //var task3 = new Task<double>(() => Formula.Comp3(10));
            //task1.Start();
            //task2.Start();
            //task3.Start();


            //var tasks1 = new Task<double>[]
            //{
            //    new Task<double>(() => Formula.Comp1(3, 5)),
            //    new Task<double>(() => Formula.Comp2(3)),
            //    new Task<double>(() => Formula.Comp3(10))
            //};

            //foreach (var task in tasks1)
            //    task.Start();

            //var tasks2 = new Task<double>[] { task1, task2, task3 };

            //var taskF1 = new Task(() => Formula.Form(tasks1[0].Result, tasks1[1].Result, tasks1[2].Result));
            //var taskF2 = new Task(() => Formula.Form(tasks2[0].Result, tasks2[1].Result, tasks2[2].Result));
            //var taskW = taskF1.ContinueWith(Formula.ContEx);

            //taskF1.Start(); 
            //taskF2.Start();

            //Console.ReadLine();

            //ParallelLoopResult result1 = Parallel.For(1, 30, Generator.Generate);
            //var list = Generator.Generate2(100000);

            //ParallelLoopResult result2 = Parallel.ForEach(list, Generator.Add);
            var ex = new BlokingC();

            int[] goods1 = { 1, 2, 3, 4, 5 };
            int[] goods2 = { 1, 2, 3, 4, 5 };

            var task1 = new Task(() => ex.AddGoods(goods1));
            var task2 = new Task(() => ex.BuyGoods(10));
            var task3 = new Task(() => ex.AddGoods(goods2));

            task1.Start();
            task3.Start();
            task2.Start();

            Console.ReadLine();
        }
    }
}
