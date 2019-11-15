using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BBarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            Customer[] customers = new Customer[]
            {
                new Customer ("Ivan", bar),
                new Customer ("Dragan", bar),
                new Customer ("Petar", bar),
                new Customer ("Maria", bar),
                new Customer ("Ana", bar),
                new Customer ("Gergana", bar),
                new Customer ("Angela", bar),
                new Customer ("Kliment", bar),
                new Customer ("Metodiy", bar)
            };

            var threads = customers.Select(c => new Thread(c.PaintTheTownRed)).ToArray();
            foreach (var t in threads) t.Start();
            foreach (var t in threads) t.Join();

            Console.WriteLine();
            Console.WriteLine("Party is over!");
            Console.ReadLine();
        }
    }
}
