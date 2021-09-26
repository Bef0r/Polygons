using Nancy.Json;
using Polygons.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Polygons.Business_Logics.SaveAndLoadFile
{
    class SaveAndLoadImp : ISaveAndLoad
    {
        public bool saveMainWindowSettings(MainWindowSettings mainWindowSettings)
        {
            bool isFileWriteSuccessful = true;
            StreamWriter outputFile = null;
            try
            {
                writeSettingsToFile(ref mainWindowSettings, ref outputFile);
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
