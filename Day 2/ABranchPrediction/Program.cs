using System;
using System.Diagnostics;
using System.Linq;

namespace ABranchPrediction
{
    class Program
    {
        static int dataSize = 20_000_000;
        static int[] data = new int[dataSize];

        static void GenerateData()
        {
            Random rand = new Random();
            for (int i = 0; i < dataSize; i++)
            {
                data[i] = rand.Next(10);
            }
            //data = Enumerable.Repeat(0, dataSize).Select(n => rand.Next(10)).ToArray();
        }

        static int CountSmaller(int boundary)
        {
            int count = 0;
            for (int i = 0; i < dataSize; i++)
            {
                if (data[i] < boundary) count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            GenerateData();
            Stopwatch watch = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                watch.Restart();
                int count = CountSmaller(i);
                watch.Stop();
                Console.WriteLine($"{i}: count: {count}, elapsed time: {watch.ElapsedMilliseconds}");
            }
            Console.ReadLine();
        }
    }
}
