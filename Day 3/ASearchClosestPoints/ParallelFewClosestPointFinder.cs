using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASearchClosestPoints
{
    class ParallelFewClosestPointFinder : ClosestPointFinderBase
    {
        public ParallelFewClosestPointFinder(Point[] input, Point[] searchPoints)
            : base(input, searchPoints)
        {

        }

        private class FindWorker2Params
        {
            public Point[] Result { get; set; }
            public int Low { get; set; }
            public int High { get; set; }
        }

        private void FindWorker2(object obj)
        {
            var p = (FindWorker2Params)obj;
            for (int i = p.Low; i < p.High; i++)
            {
                p.Result[i] = FindClosestInputPoint(searchPoints[i]);
            }
        }

        public override Point[] Find()
        {
            List<Thread> workers = new List<Thread>();
            Point[] result = new Point[searchPoints.Length];

            int parallelCount = 8;
            int rangeSize = searchPoints.Length / parallelCount;

            for (int i = 0; i < parallelCount; i++)
            {
                Thread thread = new Thread(FindWorker2);
                var p = new FindWorker2Params()
                {
                    Result = result,
                    Low = rangeSize * i,
                    High = rangeSize * (i + 1)
                };
                thread.Start(p);
                workers.Add(thread);
            }
            foreach (var t in workers) t.Join();
            return result;
        }
    }
}
