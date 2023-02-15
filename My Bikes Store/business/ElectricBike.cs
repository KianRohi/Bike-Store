using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bikes_Store.business
{
    [Serializable]
    class ElectricBike : Bike
    {
        private bool longRange;
        private bool quickCharger;

        public bool LongRange
        {
            get
            {
                return this.longRange;
            }
            set
            {
                this.longRange = value;
            }
        }

        public bool QuickCharger
        {
            get
            {
                return this.quickCharger;
            }
            set
            {
                this.quickCharger = value;
            }
        }

        //String printing format

        public override string ToString()
        {
            string state;
            state = "Electric Bike | " + this.serial_number + " | " + this.make + " | " +
                     this.color + " | " + this.speed + " | " + this.date + " | " + this.longRange + " | " + this.quickCharger;

            return state;
        }

        public override void SpeedUp(double newSpeed)
        {
            if (this.speed + newSpeed < this.GetMaxSpeed())
            {
                this.speed += newSpeed;
            }
        }
    }
}
