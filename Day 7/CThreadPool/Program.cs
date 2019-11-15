using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(
                (obj) =>
                {
                    Console.WriteLine($"Hello from the thread pool, thread id: {Thread.CurrentThread.ManagedThreadId}");
                });
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadLine();
        }
    }
}
