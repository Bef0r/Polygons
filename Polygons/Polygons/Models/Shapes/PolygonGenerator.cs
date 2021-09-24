using System;
using System.Windows;
using System.Windows.Shapes;

namespace Polygons.Models.Shapes
{
    public class PolygonGenerator
    {
        private int maximumXCoordinateValue;
        private int maximumYCoordinateValue;
        private int minimumXCoordinateValue;
        private int minimumYCoordinateValue;
        private readonly int numberOfVerticesOfPolygon;
        private readonly Random coordinateGenerator;

        public PolygonGenerator(int numberOfVerticesOfPolygon)
        {
            this.coordinateGenerator = new Random();
            this.numberOfVerticesOfPolygon = numberOfVerticesOfPolygon;
            maximumXCoordinateValue = 450;
            maximumYCoordinateValue = 250;
            minimumXCoordinateValue = 10;
            minimumYCoordinateValue = 10;
        }


        #region setters
        public PolygonGenerator setMaximumXAxisValue(int maximumXValue)
        {
            this.maximumXCoordinateValue = maximumXValue;
            return this;
        }

        public PolygonGenerator setMaximumYAxisValue(int maximumYValue)
        {
            this.maximumYCoordinateValue = maximumYValue;
            return this;
        }

        public PolygonGenerator setMinimumXAxisValue(int minimumXValue)
        {
            this.minimumXCoordinateValue = minimumXValue;
            return this;
        }

        public PolygonGenerator setMinimumYAxisValue(int minimumYValue)
        {
            this.minimumYCoordinateValue = minimumYValue;
            return this;
        }

        #endregion

        public Polygon build()
        {
            Polygon newPolygon = new Polygon();
            setPolygonParameters(ref newPolygon);
            for (int i = 0; i < numberOfVerticesOfPolygon; i++)
            {
                newPolygon.Points.Add(generateNewPointToPolygon());
            }
            return newPolygon;
        }


        #region generateNewPoint
        protected Point generateNewPointToPolygon()
        {
            return new Point(generateNewXCoordinate(), generateNewYCoordinate());
        }

        #region coordiante generate
        protected int generateNewXCoordinate()
        {
            return coordinateGenerator.Next(minimumXCoordinateValue, maximumXCoordinateValue);
        }

        protected int generateNewYCoordinate()
        {
            return coordinateGenerator.Next(minimumYCoordinateValue, maximumYCoordinateValue);
        }
        #endregion

        #endregion

        protected void setPolygonParameters(ref Polygon polygon)
        {
            polygon.Stroke = System.Windows.Media.Brushes.Black;
            polygon.Fill = System.Windows.Media.Brushes.LightSeaGreen;
            polygon.StrokeThickness = 2;
        }
    }
}
