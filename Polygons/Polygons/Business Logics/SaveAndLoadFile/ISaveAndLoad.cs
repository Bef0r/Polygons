using Polygons.Models;

namespace Polygons.Business_Logics.SaveAndLoadFile
{
    interface ISaveAndLoad
    {
        bool saveMainWindowSettings(MainWindowSettings mainWindowSettings1);
        MainWindowSettings loadMainWindowSettings();
    }
}
