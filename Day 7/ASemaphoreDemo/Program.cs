using System;
using System.Threading;

namespace ASemaphoreDemo
{
    class Program
    {
        static Semaphore semaphore;

        static void Worker (object tag)
        {
            Console.WriteLine($"{tag} starts.");
            semaphore.WaitOne();
            Console.WriteLine($"{tag} enters.");
            Thread.Sleep(1000);
            semaphore.Release();
            Console.WriteLine($"{tag} ends.");
        }

        static void Main(string[] args)
        {
            semaphore = new Semaphore(0, 3); //Maximum three can enter, but initially no one can, until we allow so.
            semaphore = new Semaphore(3, 3); //Maximum three can enter, and initially three can enter.

            for(int i = 0; i < 10; i++)
            {
                Thread t = new Thread(Worker);
                t.Start(i);
            }

            Console.ReadLine();
        }
    }
}
