using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Helper
{
    class Converter
    {
        public static int doubleToInteger(double value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (FormatException)
            {
                throw;
            }

        }

        public static int stringToInteger(String value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (FormatException)
            {
                throw;
            }
        }
    }
}
