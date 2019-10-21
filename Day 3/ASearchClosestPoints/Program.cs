using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ASearchClosestPoints
{
    class Program
    {
        const int inputDataSize = 1_000_000;
        const int searchSize = 500;

        static void Main(string[] args)
        {
            Console.Write("Generating mockup data...  ");
            Point[] inputData = PointFactory.GenerateRandomPoints(inputDataSize);
            Point[] searchPoints = PointFactory.GenerateRandomPoints(searchSize);
            Console.WriteLine("Done.");

            Console.Write("Find closest points...   ");
            ClosestPointFinderBase finder;
            
            finder = new LinearClosestPointFinder(inputData, searchPoints);
            Stopwatch watch = new Stopwatch();
            watch.Restart();
            Point[] closest = finder.Find();
            watch.Stop();
            Console.WriteLine($"Done ({watch.ElapsedMilliseconds} ms).");

            Console.Write("Find closest points (parallel)...   ");
            finder = new ParallelClosestPointFinder(inputData, searchPoints);
            watch.Restart();
            closest = finder.Find();
            watch.Stop();
            Console.WriteLine($"Done ({watch.ElapsedMilliseconds} ms).");

            Console.Write("Find closest points (parallel 2)...   ");
            finder = new ParallelFewClosestPointFinder(inputData, searchPoints);
            watch.Restart();
            closest = finder.Find();
            watch.Stop();
            Console.WriteLine($"Done ({watch.ElapsedMilliseconds} ms).");

            Console.WriteLine();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
