using System;
using System.Collections.Generic;
using System.Threading;

namespace CThreadPriorities
{
    class Program
    {
        static bool KeepWorking = true;
        static void ThreadWorker()
        {
            while (KeepWorking) ;
        }

        static void Main(string[] args)
        {
            int coreCount = System.Environment.ProcessorCount;
            List<Thread> workers = new List<Thread>();
            for (int i = 0; i < coreCount; i++)
            {
                Thread worker = new Thread(ThreadWorker);
                worker.Priority = ThreadPriority.Lowest;
                worker.Start();
                workers.Add(worker);
            }
            Console.WriteLine("Application is running...  Press ENTER to quit.");
            Console.ReadLine();
            KeepWorking = false;
            foreach (var w in workers) w.Join();
        }
    }
}
