using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Business_Logics.CoordinateSystem
{
    public class DistanceBetweenTwoPoint
    {
        public static double calculateDistanceBetweenTwoPoint(double firstPointXCoordiante, double firstPointYCoordiante, double secondPointXCoordiante, double secondPointYCoordiante)
        {
            return Math.Sqrt(subtractionAndPow(firstPointXCoordiante, secondPointXCoordiante) + subtractionAndPow(firstPointYCoordiante, secondPointYCoordiante));
        }

        protected static double subtractionAndPow(double firstCoordiante, double secondCoordiante)
        {
            return Math.Pow((secondCoordiante - firstCoordiante), 2);
        }

    }
}
