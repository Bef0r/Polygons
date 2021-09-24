using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Polygons.ViewModels
{
    class CanvasViewModel
    {
        public CanvasViewModel(Canvas myCanvas)
        {
            this.myCanvas = myCanvas;
        }

        public Canvas myCanvas { get; set; }
    }
}
