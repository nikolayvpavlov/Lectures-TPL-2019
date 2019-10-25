using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BLockingExercise
{
    class Program
    {
        static int sum = 0;
        static int[] data;

        static object objLock = new object();

        static void Worker(object p)
        {
            int index = (int)p;
            lock (objLock)
            {
                sum += data[index];
            }
        }

        static void Main(string[] args)
        {
            data = Enumerable.Range(1, 100).ToArray();
            var threads = new List<Thread>();
            for (int i = 0; i < data.Length; i++)
            {
                var thread = new Thread(Worker);
                thread.Start(i);
                threads.Add(thread);
            }
            foreach (var t in threads) t.Join();
            Console.WriteLine("Sum: " + sum.ToString());
            Console.ReadLine();
        }
    }
}
