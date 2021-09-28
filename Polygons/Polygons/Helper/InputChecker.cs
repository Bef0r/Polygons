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

        public static bool NumberOfVerticesOfPolygonChecker(String input)
        {
            try
            {
                return (isNumber(input) && isInputBiggerThanMinimum() && isInputSmallerThanMaximum()) ? true : false;
            }
            catch (FormatException)
            {
                throw;
            }
        }

        protected static bool isNumber(String input)
        {
            try
            {
                return int.TryParse(input, out convertedValueToInt);
            }
            catch (FormatException)
            {
                throw;
            }

        }

        protected static bool isInputBiggerThanMinimum()
        {
            try
            {
                return convertedValueToInt > MINIMUM_VALUE;
            }
            catch (FormatException)
            {
                throw;
            }
        }

        protected static bool isInputSmallerThanMaximum()
        {
            try
            {
                return convertedValueToInt <= MAXIMUM_VALUE;
            }
            catch (FormatException)
            {
                throw;
            }
        }
    }
}
