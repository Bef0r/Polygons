using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Models.Polygons
{
    class NewPolygonParameters
    {
        public int canvasWidth { get; }
        public int canvasHeight { get; }
        public int numberOfVerticesOfPolygon { get; }

        public NewPolygonParameters(int canvasWidth, int canvasHeight, int numberOfVerticesOfPolygon)
        {
            this.canvasWidth = canvasWidth;
            this.canvasHeight = canvasHeight;
            this.numberOfVerticesOfPolygon = numberOfVerticesOfPolygon;
        }

    }
}
