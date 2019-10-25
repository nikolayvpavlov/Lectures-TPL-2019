using System;
using System.Collections.Generic;
using System.Threading;

namespace FWaitHandlersOrchestration
{
    class Program
    {
        static ManualResetEvent eventStart = new ManualResetEvent(false);

        static void Worker(object tag)
        {
            eventStart.WaitOne();
            Console.WriteLine($"{tag} started.");
            Thread.Sleep(500); //Do something silly.
            Console.WriteLine($"{tag} finished.");
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread t = new Thread(Worker);
                t.Start(i);
            }
            Thread.Sleep(1000); //Do something else...

            //Set the bulls free!
            eventStart.Set();

            Console.ReadLine();
        }
    }
}
