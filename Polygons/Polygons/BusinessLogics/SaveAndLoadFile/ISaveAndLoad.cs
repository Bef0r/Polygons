using Polygons.Models;
using System.Collections.Generic;
using System.Windows.Media;

namespace Polygons.Business_Logics.SaveAndLoadFile
{
    interface ISaveAndLoad
    {
        bool saveMainWindowSettings(MainWindowSettings mainWindowSettings1);
        MainWindowSettings loadMainWindowSettings();

        bool saveDistrictOfPolygonsAndNumberOfVerticesOfPolygons();
    }
}
