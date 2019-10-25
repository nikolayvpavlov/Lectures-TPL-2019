using System;
using System.Threading;

namespace DDeadlockDemo
{
    class Program
    {
        static object lockOne = new object();
        static object lockTwo = new object();

        static void WorkerOne()
        {
            Console.WriteLine("Worker one started.");
            lock (lockOne)
            {
                Console.WriteLine("One: Lock one acquired.");
                Thread.Sleep(10);
                lock (lockTwo)
                {
                    Console.WriteLine("Worker one entered the magical kingdom");
                }
            }
            Console.WriteLine("Worker one ended.");
        }

        static void WorkerTwo()
        {
            Console.WriteLine("Worker two started.");
            lock (lockTwo)
            {
                Console.WriteLine("Two: Lock two acquired.");
                Thread.Sleep(10);
                lock (lockOne)
                {
                    Console.WriteLine("Worker two entered the critical zone");
                }
            }
            Console.WriteLine("Worker two ends.");
        }

        static void Main(string[] args)
        {
            Thread one = new Thread(WorkerOne);
            Thread two = new Thread(WorkerTwo);
            one.Start();
            two.Start();
            Console.WriteLine("Threads started...");
            one.Join();
            two.Join();
            Console.WriteLine("Finished.");
            Console.ReadLine();
        }
    }
}
