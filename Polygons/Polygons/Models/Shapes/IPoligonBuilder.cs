using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Polygons.Models.Shapes
{
    interface IPoligonBuilder
    {
     void setNumberOfVerticesOfPolygon(int numberOfVerticesOfPolygon);
        void setMinimumXAxisValue(int minimumXValue);
        void setMinimumYAxisValue(int minimumYValue);
        void setMaximumXAxisValue(int maximumXValue);
        void setMaximumYAxisValue(int maximumYValue);
        Polygon build();
    }
}
