using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Polygons.Models.Polygons
{
    public class GeneratePolygonsStorage
    {
        private static LinkedList<PointCollection> pointsOfPolygons;
        private static GeneratePolygonsStorage storage;
        private GeneratePolygonsStorage()
        {
            pointsOfPolygons = new LinkedList<PointCollection>();
        }

        public static GeneratePolygonsStorage getInstance()
        {
            if (storage == null)
            {
                storage = new GeneratePolygonsStorage();
            }
            return storage;
        }

        public void addNewPoints(PointCollection points)
        {
            pointsOfPolygons.AddFirst(points);
        }

        public LinkedList<PointCollection> getAllPoint()
        {
            return pointsOfPolygons;
        }
    }
}
