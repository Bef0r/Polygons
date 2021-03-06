using Nancy.Json;
using Polygons.Business_Logics.CoordinateSystem;
using Polygons.Business_Logics.Database;
using Polygons.Business_Logics.SaveAndLoadFile;
using Polygons.Models;
using Polygons.Models.Polygons;
using Polygons.Models.Shapes;
using Polygons.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
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

        public bool saveDistrictOfPolygonsAndNumberOfVerticesOfPolygons()
        {
            return saveAndLoad.saveDistrictOfPolygonsAndNumberOfVerticesOfPolygons();
        }

        public bool saveMainWindowSettings(MainWindowSettings mainWindowSettings)
        {
            return saveAndLoad.saveMainWindowSettings(mainWindowSettings);
        }

        public bool saveDataToDatabase()
        {
            LinkedList<PointCollection> allPoints = storage.getAllPoint();
            DatabaseContext database = DatabaseContext.getInstance();
            if (database.connectToDataBase())
            {
                foreach (PointCollection point in allPoints)
                {
                    double distance = DistanceCalculator.calculate(point);
                    database.saveToDatabase(point.Count, distance);
                }
                closeDatabase(database);
                return true;
            }
            else
            {
                closeDatabase(database);
                return false;
            }

        }

        protected void closeDatabase(DatabaseContext database)
        {
            if (database.isConnected())
            {
                database.disconnectFromoDataBase();
            }
        }
    }
}
