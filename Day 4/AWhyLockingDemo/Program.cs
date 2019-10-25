using System;
using System.Threading;

namespace AWhyLockingDemo
{
    class Program
    {
        static int data = 100;

        static object objLock = new object();
        
        static void ThreadWorker (object tag)
        {
            //object objLock = new object();  //WRONG: now each thread has its own lock, and disregards other's locks
            for (int i = 0; i < 10; i++)
            {
                //Monitor.Enter(objLock);
                lock (objLock)
                {
                    data++;
                    Thread.Sleep(3);
                    data--;
                    Console.WriteLine(tag.ToString() + ": " + data.ToString());
                }
                //Monitor.Exit(objLock);
            }
        }

        static void Main(string[] args)
        {
            Thread one = new Thread(ThreadWorker);
            Thread two = new Thread(ThreadWorker);
            one.Start("One");
            two.Start("Two");

            int a = 10;
            object objA = a; //BOXING
            a = (int)objA; //UNBOXING


            one.Join();
            two.Join();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
