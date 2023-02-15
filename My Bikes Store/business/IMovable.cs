using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bikes_Store.business
{
    interface IMovable
    {
        double GetMaxSpeed();
        void SpeedUp(double newSpeed);

    }
}
