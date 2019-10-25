using System;
using System.Threading;

namespace EWaitHandlersDemo
{
    class Program
    {
        static ManualResetEvent eventCompleted = new ManualResetEvent(false);

        static void Worker()
        {
            Console.WriteLine("Worker started.");
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
            }
            Console.WriteLine("Worker completed.");

            eventCompleted.Set();
        }

        static void Main(string[] args)
        {
            Thread aThread = new Thread(Worker);
            aThread.Start();
            Console.Write("Waiting for the worker.");
            
            while ( ! eventCompleted.WaitOne(100))
            {
                Console.Write(".");
            }
            Console.WriteLine();
            
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();


        }
    }
}
