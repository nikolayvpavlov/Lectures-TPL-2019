using System;
using System.Threading;

namespace DThreadsExceptions
{
    class Program
    {
        static bool WorkerFailed = false;
        static Exception WorkerFailException;

        static void ThreadWorker()
        {
            try
            {
                Console.WriteLine("My thread is doing something...");
                Random rand = new Random();
                if (rand.Next(2) == 0)
                {
                    throw new Exception("Ops, some error occured.");
                }
                Console.WriteLine("My thread is done.");
            }
            catch (Exception x)
            {
                Console.WriteLine("Well, I screwed up, but I got it.");
                WorkerFailed = true;
                WorkerFailException = x;
            }
        }

        static void Main(string[] args)
        {
            Thread myThread = new Thread(ThreadWorker);
            myThread.Start();
            myThread.Join();
            if (WorkerFailed)
            {
                Console.WriteLine("Worker failed with error: " + WorkerFailException.Message);
            }
            else
            {
                Console.WriteLine("All good!");
            }

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
