using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CProtectLists
{
    class Program
    {
        static List<int> someList = new List<int>();

        static void Worker ()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var value = rand.Next(10_000);
                lock (someList)
                {
                    someList.Add(value);
                }
            }
        }

        static void Main(string[] args)
        {
            var threads =
                Enumerable
                .Range(1, 10)
                .Select(i => new Thread(Worker)).ToArray();

            foreach (var t in threads) t.Start();

            Console.WriteLine("Working...");
            foreach (var t in threads) t.Join();
            Console.WriteLine("Ready.");
            Console.ReadLine();
        }
    }
}
