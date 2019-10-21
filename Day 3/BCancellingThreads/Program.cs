using System;
using System.Threading;

namespace BCancellingThreads
{
    class Program
    {
        static volatile bool IsThreadRunning;
        static volatile bool ShouldCancel; 

        static void ThreadWorker(object obj)
        {
            CancellationToken token = (CancellationToken)obj;
            IsThreadRunning = true;
            for (int i = 0; i < 1000; i++)
            {
                //The correct way to cancel.  Stop what you are doing,
                // and perform all the necessary cleanup before exiting the method.
                if (token.IsCancellationRequested)
                {
                    break; //Stops the loop but will execute IsThreadRunning = false;
                }
                Thread.Sleep(10);
            }
            IsThreadRunning = false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Doing something slow in a thread.");
            Console.WriteLine("Press 'c' to cancel.");
            Console.WriteLine();

            var cts = new CancellationTokenSource();

            Thread thread = new Thread(ThreadWorker);
            thread.Start(cts.Token); 
            IsThreadRunning = true;
            Console.Write("Progress: ");
            while (IsThreadRunning)
            {
                Console.Write(".");
                Thread.Sleep(500);
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).KeyChar == 'c')
                    {
                        //thread.Abort();  //NEVER USE this.  NEVER.  NEVER EVER.  Did I say NEVER?
                        //ShouldCancel = true; //Better.  This generally works.
                        cts.Cancel();  //Best!
                        thread.Join();
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
