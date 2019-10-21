using System;
using System.Collections.Generic;

namespace ASearchClosestPoints
{
    class PointFactory
    {
        static Random rand = new Random();

        public static Point[] GenerateRandomPoints(int count, double minValue = 1000, 
            double maxValue = 10_000)
        {
            Point[] result = new Point[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = new Point()
                {
                    X = minValue + rand.NextDouble() * (maxValue - minValue),
                    Y = minValue + rand.NextDouble() * (maxValue - minValue),
                    Z = minValue + rand.NextDouble() * (maxValue - minValue)
                };
            }
            return result;
        }
    }
}
