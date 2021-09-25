using Polygons.Models.Polygons;
using Polygons.Models.Shapes;
using Polygons.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Polygons.Business_Logics
{
    class UICommandsImp : IUICommands
    {
        public CanvasViewModel generateNewPolygon(NewPolygonParameters newPolygonParameters)
        {
            Polygon newPolygon = new PolygonGenerator(newPolygonParameters.numberOfVerticesOfPolygon).setMaximumXAxisValue(newPolygonParameters.canvasWidth).setMaximumYAxisValue(newPolygonParameters.canvasHeight).build();
            Canvas canvas = new Canvas();
            canvas.Children.Add(newPolygon);
            return new CanvasViewModel(canvas);
        }
    }
}
