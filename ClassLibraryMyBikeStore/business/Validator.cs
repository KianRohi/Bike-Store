using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMyBikeStore.business
{
    static class Validator
    {

        public static bool CheckSerialNumber(string d)
        {
            bool result = long.TryParse(d, out long i);

            return result;
        }


        public static bool CheckSpeed(string d)
        {

            bool result = double.TryParse(d, out double i);

            return result;
        }


        public static bool CheckMake(string d)
        {

            bool result = int.TryParse(d, out int i);

            if (result)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public static bool CheckSeatHeight(string d)
        {
            bool result = int.TryParse(d, out int i);

            return result;
        }


        public static bool CheckHeightFromGround(string d)
        {
            bool result = int.TryParse(d, out int i);

            return result;
        }

        public static bool CheckTiresSize(string d)
        {
            double i = 0;
            bool result = double.TryParse(d, out i);

            return result;
        }


    }
}
