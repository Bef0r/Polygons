using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Business_Logics.CoordinateSystem
{
    public class DistanceBetweenTwoPoint
    {
        public static double calculateDistanceBetweenTwoPoint(int firstPointXCoordiante, int firstPointYCoordiante, int secondPointXCoordiante, int secondPointYCoordiante)
        {
            return Math.Sqrt(subtractionAndPow(firstPointXCoordiante, secondPointXCoordiante) + subtractionAndPow(firstPointYCoordiante, secondPointYCoordiante));
        }

        protected static double subtractionAndPow(int firstCoordiante, int secondCoordiante)
        {
            return Math.Pow((Convert.ToDouble(secondCoordiante) - Convert.ToDouble(firstCoordiante)), 2);
        }

    }
}
