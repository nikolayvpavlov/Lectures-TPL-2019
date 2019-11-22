using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMoreAsyncAwait
{
    class Program
    {
        static async Task<int> GetTheUltimateAnswerAsync()
        {
            await Task.Delay(1000);
            return 42;
        }

        static async Task DoSomethingBad(int value)
        {
            await Task.FromResult(value);
            throw new Exception("Something bad happened.");
        }

        static async Task DoSomethingAsync ()
        {
            int value;
            value = await GetTheUltimateAnswerAsync();
            await DoSomethingBad(value);
            Console.WriteLine(value);
        }

        static async Task TopMethod()
        {
            try
            {
                await DoSomethingAsync();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        static void Main(string[] args)
        {
            //DoSomethingAsync().Wait();

            TopMethod().Wait();

            Console.ReadLine();
        }
    }
}
