using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Polygons.Business_Logics.CoordinateSystem
{
    class DistanceCalculator
    {
        public static double calculate(PointCollection point)
        {
            return calculateDistance(point);
        }

        protected static double calculateDistance(PointCollection point)
        {
            double distance = 0;
            for (int i = 0; i < point.Count - 1; i++)
            {
                distance = distance + DistanceBetweenTwoPoint.calculateDistanceBetweenTwoPoint(point[i].X, point[i].Y, point[i + 1].X, point[i + 1].Y);
            }
            distance = distance + calculateDistanceBetweenFirstAndLastPoints(point);
            return distance;
        }

        protected static double calculateDistanceBetweenFirstAndLastPoints(PointCollection point)
        {
            return DistanceBetweenTwoPoint.calculateDistanceBetweenTwoPoint(point[0].X, point[0].Y, point[point.Count - 1].X, point[point.Count - 1].Y);
        }
    }
}
