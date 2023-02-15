using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bikes_Store.business
{
   public class BikeException : Exception
    {
        private static string message = "An error has occurred, please try again :)";


       
        public BikeException() : base(message)
        {

        }

        public BikeException(string msg) : base(msg)
        {

        }
    }
}
