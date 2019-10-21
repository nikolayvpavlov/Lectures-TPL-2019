using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASearchClosestPoints
{
    class ParallelClosestPointFinder : ClosestPointFinderBase 
    {
        private class FindWorkerParams
        {
            public Point[] Result { get; set; }
            public int Index { get; set; }
        }

        private void FindWorker(object obj)
        {
            var p = (FindWorkerParams)obj;
            p.Result[p.Index] = FindClosestInputPoint(searchPoints[p.Index]);
        }

        public ParallelClosestPointFinder (Point[] input, Point[] searchPoints)
            : base(input, searchPoints)
        {

        }

        public override Point[] Find()
        {
            List<Thread> workers = new List<Thread>();
            Point[] result = new Point[searchPoints.Length];
            for (int i = 0; i < searchPoints.Length; i++)
            {
                Thread thread = new Thread(FindWorker);
                thread.Start(new FindWorkerParams() { Result = result, Index = i });
                workers.Add(thread);
            }
            foreach (var t in workers) t.Join();
            return result;
        }
    }
}
