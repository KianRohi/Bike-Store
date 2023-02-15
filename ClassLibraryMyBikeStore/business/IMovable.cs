using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMyBikeStore.business
{
    interface IMovable
    {
        double GetMaxSpeed();
        void SpeedUp(double newSpeed);

    }
}
