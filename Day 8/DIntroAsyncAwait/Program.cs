using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DIntroAsyncAwait
{
    class Program
    {
        static string Get42() { return "42"; }
        static async Task DoSomethingAsync()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("Bye from " + Thread.CurrentThread.ManagedThreadId);
        }

        static Task DoSomethingStep1()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.ManagedThreadId);
            return Task.Delay(1000);
        }

        static void DoSomethingStep2()
        {
            Console.WriteLine("Bye from " + Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            //var task = DoSomethingAsync();
            //task.Wait();

            var task = DoSomethingStep1()
                        .ContinueWith(p => DoSomethingStep2());
            task.Wait();

            Console.ReadLine();
        }
    }
}
