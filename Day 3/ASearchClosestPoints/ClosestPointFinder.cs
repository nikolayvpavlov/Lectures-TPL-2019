using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASearchClosestPoints
{
    /// <summary>
    /// For every point in SearchPoints finds the point from inputData that is closest to it.
    /// </summary>
    abstract class ClosestPointFinderBase
    {
        protected Point[] inputData;
        protected Point[] searchPoints;

        public ClosestPointFinderBase(Point[] input, Point[] searchPoints)
        {
            inputData = input;
            this.searchPoints = searchPoints;
        }

        protected Point FindClosestInputPoint(Point pnt)
        {
            Point result = null;
            double distance = double.MaxValue;
            foreach (var p in inputData)
            {
                double current = pnt.GetDistanceFromPoint(p);
                if (current < distance)
                {
                    distance = current;
                    result = p;
                }
            }
            return result;
        }

        public abstract Point[] Find();

    }
}
