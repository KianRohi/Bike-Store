using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryMyBikeStore.business
{
    class RoadBike : Bike
    {

        //########################################################
        //Extra Attributes
        //########################################################

        private EnumSuspension suspension;
        private double heightFromGround;
        private bool absSupport;

        //########################################################
        //public property
        //########################################################

        public EnumSuspension Suspension
        {
            get
            {
                return this.suspension;
            }
            set
            {
                this.suspension = value;
            }
        }


        public bool AbsSupport
        {
            get
            {
                return this.absSupport;
            }
            set
            {
                this.absSupport = value;
            }
        }

        public double HeightFromGround
        {
            get
            {
                return this.heightFromGround;
            }
            set
            {
                this.heightFromGround = value;
            }
        }

        //########################################################
        // Constructor
        //########################################################

        //public constructors
        public RoadBike() : base()
        {
            this.suspension = EnumSuspension.Front;
            this.heightFromGround = 0.0;
            this.absSupport = true;
        }

        //Copy constructor
        public RoadBike(RoadBike newRoadBike) : base(newRoadBike)
        {
            this.suspension = newRoadBike.suspension;
            this.heightFromGround = newRoadBike.heightFromGround;
            this.absSupport = newRoadBike.absSupport;
        }

        //public constructor with parameters
        public RoadBike(long serial_number, string make, double speed, EnumColor color, DateTime date, EnumSuspension suspension, double heightFromGround, bool absSupport)
                                                                    : base(serial_number, make, speed, color, date)
        {
            this.suspension = suspension;
            this.heightFromGround = heightFromGround;
            this.absSupport = absSupport;
        }

        //########################################################
        //Methods
        //########################################################

        public override string ToString()
        {
            string state;
            state = "Road Bike | " + this.serial_number + " | " + this.make + " | " +
                     this.color + " | " + this.speed + " | " + this.date + " | " + this.suspension + " | " + this.heightFromGround + " | ABS:" + this.absSupport;

            return state;
        }

        public override void SpeedUp(double newSpeed)
        {
            if (this.speed + newSpeed < this.GetMaxSpeed())
            {
                this.speed += newSpeed;
            }
        }


        public override double GetMaxSpeed()
        {
            this.speed = 40;
            return this.speed;
        }



    }
}
