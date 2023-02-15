using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bikes_Store.business
{
    [Serializable]
    class MountainBike : Bike
    {

        //########################################################
        //Extra Attributes
        //########################################################

        private double seatHeight;
        private double tiresSize;

        //########################################################
        //public property
        //########################################################

        public double SeatHeight
        {
            get
            {
                return this.seatHeight;
            }
            set
            {
                this.seatHeight = value;
            }
        }

        public double TiresSize
        {
            get
            {
                return this.tiresSize;;
            }
            set
            {
                this.tiresSize = value;
            }
        }

        //########################################################
        // Constructor
        //########################################################

        //public constructors
        public MountainBike() : base()
        {
            this.seatHeight = 0.0;
            this.tiresSize = 0.0;
        }

        //Copy constructor
        public MountainBike(MountainBike newRoadBike) : base(newRoadBike)
        {
            this.seatHeight = newRoadBike.seatHeight;
            this.tiresSize = newRoadBike.tiresSize;
        }

        //public constructor with parameters
        public MountainBike(long serial_number, string make, double speed, EnumColor color, DateTime date, double seatHeight, double tiresSize)
                                                                    : base(serial_number, make, speed, color, date)
        {
            this.seatHeight = seatHeight;
            this.tiresSize = tiresSize;
        }


        //########################################################
        //Methods
        //########################################################

        //String printing format

        public override string ToString()
        {
            string state;
            state = "Mountain Bike | " + this.serial_number + " | " + this.make + " | " +
                     this.color + " | " + this.speed + " | " + this.date + " | " + this.seatHeight + " | " + this.tiresSize;

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
