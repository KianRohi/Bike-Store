namespace My_Bikes_Store.business
{
    static class Validator
    {
        //takes a string and converts it into another data type and stores the result, 
        //taking wether or not the conversion was succesful

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
