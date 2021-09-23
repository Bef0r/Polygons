using System;
using System.Windows;
using System.Windows.Shapes;

namespace Polygons.Models.Shapes
{
    class PolygonBuilder : IPoligonBuilder
    {
        #region variables
        protected Polygon newPolygon;
        protected int maximumXCoordinateValue;
        protected int maximumYCoordinateValue;
        protected int minimumXCoordinateValue;
        protected int minimumYCoordinateValue;
        protected int numberOfVerticesOfPolygon;
        protected Random coordinateGenerator;
        #endregion

        public PolygonBuilder()
        {
            this.newPolygon = new Polygon();
            this.coordinateGenerator = new Random();
            maximumXCoordinateValue = 450;
            maximumYCoordinateValue = 250;
            minimumXCoordinateValue = 10;
            minimumYCoordinateValue = 10;
        }

        #region polygonOperators
        public Polygon build()
        {
            reset();
            for (int i = 0; i < numberOfVerticesOfPolygon; i++)
            {
                addNewPointToPolygon();
            }
            return newPolygon;
        }

        public void reset()
        {
            if (newPolygon.Points.Count > 0)
            {
                newPolygon.Points.Clear();
            }
        }

        protected void addNewPointToPolygon()
        {
            newPolygon.Points.Add(new Point(generateNewXCoordinate(), generateNewYCoordinate()));
        }
        #endregion

        #region setters
        public void setMaximumXAxisValue(int maximumXValue)
        {
            this.maximumXCoordinateValue = maximumXValue;
        }

        public void setMaximumYAxisValue(int maximumYValue)
        {
            this.maximumYCoordinateValue = maximumYValue;
        }

        public void setMinimumXAxisValue(int minimumXValue)
        {
            this.minimumXCoordinateValue = minimumXValue;
        }

        public void setMinimumYAxisValue(int minimumYValue)
        {
            this.minimumYCoordinateValue = minimumYValue;
        }

        public void setNumberOfVerticesOfPolygon(int numberOfVerticesOfPolygon)
        {
            this.numberOfVerticesOfPolygon = numberOfVerticesOfPolygon;
        }
        #endregion

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

    }
}
