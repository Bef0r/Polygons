using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Models.Polygons
{
    class MyPolygon
    {
        protected double district;
        protected int numberOfVerticesOfPolygon;
        public MyPolygon(double district, int numberOfVerticesOfPolygon)
        {
            this.district = district;
            this.numberOfVerticesOfPolygon = numberOfVerticesOfPolygon;
        }

        public double District
        {
            get
            {
                return district;
            }
        }
        public int NumberOfVerticesOfPolygon
        {
            get
            {
                return numberOfVerticesOfPolygon;
            }
        }
    }
}
