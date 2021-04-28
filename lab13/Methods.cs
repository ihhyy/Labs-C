using System;
using System.Diagnostics;
using System.Threading;

namespace lab14
{
    class Methods
    {
        public static void ShowProcesses()
        {
            foreach(var process in Process.GetProcesses())
            {
                Console.WriteLine
                    ($"{process.Id}" +
                     $"{process.ProcessName}");
            }
        }

        public static void Domain()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            
            Console.WriteLine
                ($"{domain.FriendlyName}" +
                 $"{domain.BaseDirectory}");
        }

        public static void Count()
        {
            int name = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < name; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }

        public static void Pause(Thread newThread)
        {
            newThread.Abort();
        }

        public static void Start(Thread newThread)
        {
            newThread.Start();
        }

        public static void Status(Thread newThread)
        {
            Console.WriteLine
                ($"{newThread.ThreadState}" +
                $"{newThread.IsAlive}" +
                $"{newThread.Priority}" +
                $"{newThread.Name}");             
        }

        public static void Count1()
        {
            int name = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < name; i++)
            {
                Console.WriteLine(i++);
                Thread.Sleep(200);
            }
        }

        public static void Count2()
        {
            int name = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < name; i++)
            {
                Console.WriteLine(i++);
                Thread.Sleep(500);
            }
        }
    }
}
