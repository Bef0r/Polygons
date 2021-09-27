using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Helper
{
    public class InputChecker
    {
        static int convertedValueToInt;
        static int MINIMUM_VALUE = 2;
        static int MAXIMUM_VALUE = 501;
        public static Boolean NumberOfVerticesOfPolygonChecker(String input)
        {
            return (isNumber(input) && isInputBiggerThanTwo() && isInputSmallerThanFiveHundred()) ? true : false;
        }

        protected static Boolean isNumber(String input)
        {
            return int.TryParse(input, out convertedValueToInt);

        }
        protected static Boolean isInputBiggerThanTwo()
        {
            return (convertedValueToInt > MINIMUM_VALUE) ? true : false;
        }

        protected static Boolean isInputSmallerThanFiveHundred()
        {
            return (convertedValueToInt <= MAXIMUM_VALUE) ? true : false;
        }
    }
}
