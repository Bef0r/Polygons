using Polygons.Models;
using Polygons.Models.Polygons;
using Polygons.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Business_Logics
{
    interface IUICommands
    {
        CanvasViewModel generateNewPolygon(NewPolygonParameters newPolygonParameters);
        Boolean saveMainWindowSettings(MainWindowSettings mainWindowSettings);
    }
}
