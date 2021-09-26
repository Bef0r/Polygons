using Polygons.Business_Logics.SaveAndLoadFile;
using Polygons.Models.Polygons;
using Polygons.ViewModels;

namespace Polygons.Business_Logics
{
    interface IUICommands :ISaveAndLoad
    {
        CanvasViewModel generateNewPolygon(NewPolygonParameters newPolygonParameters);
        bool storageData();
    }
}
