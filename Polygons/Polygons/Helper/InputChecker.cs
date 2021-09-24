using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Helper
{
    public class InputChecker
    {
        static int convertedValueToInt;
        public static Boolean NumberOfVerticesOfPolygonChecker(String input)
        {
            return (isNumber(input) && isInputBiggerThanTwo()) ? true : false;
        }

        protected static Boolean isNumber(String input)
        {
            return int.TryParse(input, out convertedValueToInt);

        }
        protected static Boolean isInputBiggerThanTwo()
        {
            return (convertedValueToInt > 2) ? true : false;
        }
    }
}
