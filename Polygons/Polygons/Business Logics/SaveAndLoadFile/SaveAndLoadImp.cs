using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Polygons.Business_Logics.CoordinateSystem;
using Polygons.Models;
using Polygons.Models.Polygons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media;

namespace Polygons.Business_Logics.SaveAndLoadFile
{
    class SaveAndLoadImp : ISaveAndLoad
    {
        protected const String FILE_NAME = "settings.txt";
        protected const String DATA_FILE_NAME = "data.txt";
        public MainWindowSettings loadMainWindowSettings()
        {
            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                docPath = docPath + "\\" + FILE_NAME;
                return JsonConvert.DeserializeObject<MainWindowSettings>(File.ReadAllText(docPath));
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool saveDistrictOfPolygonsAndNumberOfVerticesOfPolygons()
        {
            bool isFileWriteSuccessful = true;
            StreamWriter outputFile = null;
            try
            {
                String local = Path.Combine(Environment.CurrentDirectory);
                using (outputFile = new StreamWriter(Path.Combine(local, DATA_FILE_NAME)))
                {
                    PolygonsDistrictAndNumberOfVerticesOfPolygonCalculator generatePolygonsStorage = new PolygonsDistrictAndNumberOfVerticesOfPolygonCalculator(GeneratePolygonsStorage.getInstance().getAllPoint());
                    outputFile.WriteLine(generatePolygonsStorage.ToString());
                }
            }
            catch (Exception)
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

        public bool saveMainWindowSettings(MainWindowSettings mainWindowSettings)
        {
            bool isFileWriteSuccessful = true;
            StreamWriter outputFile = null;
            try
            {
                writeSettingsToFile(ref mainWindowSettings, ref outputFile);
            }
            catch (Exception)
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
            using (outputFile = new StreamWriter(System.IO.Path.Combine(docPath, FILE_NAME)))
            {
                var json = new JavaScriptSerializer().Serialize(mainWindowSettings);
                outputFile.WriteLine(json);
            }

        }
    }
}
