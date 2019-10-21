using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASearchClosestPoints
{
    class LinearClosestPointFinder : ClosestPointFinderBase
    {

        public LinearClosestPointFinder(Point[] input, Point[] searchPoints)
            : base(input, searchPoints)
        {

        }

        public override Point[] Find()
        {
            Point[] result = new Point[searchPoints.Length];
            for (int i = 0; i < searchPoints.Length; i++)
            {
                result[i] = FindClosestInputPoint(searchPoints[i]);
            }
            return result;
        }
    }
}
