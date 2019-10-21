using System;

namespace ASearchClosestPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double GetDistanceFromPoint (Point pnt)
        {
            double dx, dy;
            dx = this.X - pnt.X;
            dy = this.Y - pnt.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
