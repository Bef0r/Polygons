﻿using Nancy.Json;
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
    class UICommandsImp : IUICommands
    {
        public CanvasViewModel generateNewPolygon(NewPolygonParameters newPolygonParameters)
        {
            Polygon newPolygon = new PolygonGenerator(newPolygonParameters.numberOfVerticesOfPolygon).setMaximumXAxisValue(newPolygonParameters.canvasWidth).setMaximumYAxisValue(newPolygonParameters.canvasHeight).build();
            Canvas canvas = new Canvas();
            canvas.Children.Add(newPolygon);
            return new CanvasViewModel(canvas);
        }

        public bool saveMainWindowSettings(MainWindowSettings mainWindowSettings)
        {
            bool isFileWriteSuccessful = true;
            StreamWriter outputFile = null;
            try
            {
                writeSettingsToFile(ref mainWindowSettings,ref outputFile);
            }
            catch (Exception ex)
            {
                isFileWriteSuccessful = false;
            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            return isFileWriteSuccessful;
        }

        protected void writeSettingsToFile(ref MainWindowSettings mainWindowSettings, ref StreamWriter outputFile)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            using (outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "settings.txt")))
            {
                var json = new JavaScriptSerializer().Serialize(mainWindowSettings);
                outputFile.WriteLine(json);
            }

        }
    }
}
