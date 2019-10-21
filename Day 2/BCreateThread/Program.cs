using System;
using System.Threading;

namespace BCreateThread
{
    class Program
    {
        static void ThreadMethod(object param)
        {
            int data = (int)param;
            data = data * 2;
            Console.WriteLine("Thread worker ends.");
            while (true) ;
        }
        static void Main(string[] args)
        {
            Thread aThread = new Thread(ThreadMethod);
            Thread bThread = new Thread(ThreadMethod);
            aThread.IsBackground = false; //This will cause the app not to end when you press ENTER.
            aThread.Start(10);
            bThread.Start(20);
            Console.WriteLine("Please enter a value: ");
            string input = Console.ReadLine();
            Console.WriteLine("Main ends.");
            Console.ReadLine();
        }
    }
}
