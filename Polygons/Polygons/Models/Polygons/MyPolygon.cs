using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Models.Polygons
{
    class MyPolygon
    {
        public double district { get; }
        public int numberOfVerticesOfPolygon { get; }

        public MyPolygon(double district, int numberOfVerticesOfPolygon)
        {
            this.district = district;
            this.numberOfVerticesOfPolygon = numberOfVerticesOfPolygon;
        }
    }
}
