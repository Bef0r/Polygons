using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Models
{
    class MainWindowSettings
    {
        public MainWindowSettings(int height, int width, bool fullScreen)
        {
            this.height = height;
            this.width = width;
            this.fullScreen = fullScreen;
        }

        public int height { set; get; }
        public int width { set; get; }
        public Boolean fullScreen { set; get; }
    }
}
