using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTaskContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task first = new Task(() => Console.WriteLine("1"));
            Task second = first.ContinueWith(prior => Console.WriteLine("2"));
            Task third = second.ContinueWith(prior => Console.WriteLine("3"));
            first.Start();
            first.Wait();

            var one = new Task<int>(() => 42);
            var two = one.ContinueWith(p => p.Result * 2);
            var three = two.ContinueWith(p => p.Result.ToString());
            one.Start(); //Runs the whole sequence
            Console.WriteLine(three.Result); //Waits for the final one to complete.


            Console.ReadLine();
        }
    }
}
