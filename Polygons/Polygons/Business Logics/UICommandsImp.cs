using Nancy.Json;
using Polygons.Business_Logics.SaveAndLoadFile;
using Polygons.Models;
using Polygons.Models.Polygons;
using Polygons.Models.Shapes;
using Polygons.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Polygons.Business_Logics
{
    class UICommandsImp : IUICommands, ISaveAndLoad
    {
        private ISaveAndLoad saveAndLoad;
        private GeneratePolygonsStorage storage;
        public UICommandsImp()
        {
            saveAndLoad = new SaveAndLoadImp();
            storage = GeneratePolygonsStorage.getInstance();
        }

        public CanvasViewModel generateNewPolygon(NewPolygonParameters newPolygonParameters)
        {
            Polygon newPolygon = new PolygonGenerator(newPolygonParameters.numberOfVerticesOfPolygon).setMaximumXAxisValue(newPolygonParameters.canvasWidth).setMaximumYAxisValue(newPolygonParameters.canvasHeight).build();
            storage.addNewPoints(newPolygon.Points);
            Canvas canvas = new Canvas();
            canvas.Children.Add(newPolygon);
            return new CanvasViewModel(canvas);
        }

        public MainWindowSettings loadMainWindowSettings()
        {
            return saveAndLoad.loadMainWindowSettings();
        }

        public bool saveMainWindowSettings(MainWindowSettings mainWindowSettings)
        {
            return saveAndLoad.saveMainWindowSettings(mainWindowSettings);
        }
    }
}
