using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIntroTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task simpleTask = new Task(() => Console.WriteLine("Hi from a task"));
            simpleTask.Start();
            simpleTask.Wait(); //Causes the current code to block until the task completes.

            Task<int> getTheUltimateAnswerTask =
                new Task<int>(() => 42);
            getTheUltimateAnswerTask.Start();
            int value = getTheUltimateAnswerTask.Result; //Will block if the task is still running.
            Console.WriteLine(value);

            Task<int> faultyTask =
                new Task<int>(() => throw new Exception("Something bad happened."));
            faultyTask.Start();
            try
            {
                faultyTask.Wait();
                int result = faultyTask.Result;
            }
            catch (Exception x) //Always AggregateException
            {
                //use x.InnerException to get the actual exception that occured.
                Console.WriteLine("Ops, my task completed with error.");
            }

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
