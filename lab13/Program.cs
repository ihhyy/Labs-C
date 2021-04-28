using System.Threading;
using System;
using System.IO;
using System.Xml.Serialization;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods.Domain();

            Thread newThread = new Thread(new ThreadStart(Methods.Count));
            Thread newThread1 = new Thread(new ThreadStart(Methods.Count1));
            Thread newThread2 = new Thread(new ThreadStart(Methods.Count2));
            //newThread.Start();
            //Methods.Status(newThread);
            newThread1.Priority = ThreadPriority.BelowNormal;
            newThread2.Priority = ThreadPriority.AboveNormal;

            newThread2.Start();
            newThread1.Start();

        }
    }
}
