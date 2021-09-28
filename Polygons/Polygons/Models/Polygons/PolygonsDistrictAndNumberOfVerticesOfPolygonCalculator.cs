using Polygons.Business_Logics.CoordinateSystem;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Polygons.Models.Polygons
{
    class PolygonsDistrictAndNumberOfVerticesOfPolygonCalculator
    {
        private LinkedList<MyPolygon> data;

        public PolygonsDistrictAndNumberOfVerticesOfPolygonCalculator(LinkedList<PointCollection> points)
        {
            data = new LinkedList<MyPolygon>();
            calcualte(points);
        }

        protected void calcualte(LinkedList<PointCollection> points)
        {
            foreach (PointCollection point in points)
            {
                data.AddFirst(new MyPolygon(DistanceCalculator.calculate(point), point.Count));
            }

        }

        public LinkedList<MyPolygon> getData()
        {
            return data;
        }

        public override string ToString()
        {

            StringBuilder stringBuilder = new StringBuilder();
            foreach (MyPolygon myPolygon in data)
            {
                stringBuilder.Append("Csúcsok száma: ");

                stringBuilder.Append(myPolygon.numberOfVerticesOfPolygon);
                stringBuilder.Append(",");
                stringBuilder.Append("Kerület összege: ");
                stringBuilder.Append(myPolygon.district);
                stringBuilder.Append('\n');
            }
            return stringBuilder.ToString();
        }
    }
}
