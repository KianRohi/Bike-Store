using System;

//Group Members: Donato Di Tullio & Seyedamirhossein Rouhi Ghodsinia


namespace ClassLibraryMyBikeStore.business
{
    public abstract class Bike : IMovable
    {

        //########################################################
        //Data Member
        //########################################################

        protected long serial_number;
        protected string make;
        protected double speed;
        protected EnumColor color;
        protected DateTime date;


        //########################################################
        //public property
        //########################################################

        public long Serial_number
        {
            get
            {
                return this.serial_number;
            }
            set
            {
                this.serial_number = value;
            }
        }


        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }


        public double Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }



        public EnumColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }


        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }




        //########################################################
        // Constructor
        //########################################################

        //constructor without parameters (parameterless constructor)
        public Bike()
        {
            this.serial_number = 0;
            this.make = "Undefined";
            this.speed = 0.0;
            this.color = EnumColor.Blue;
            this.date = default;

        }

        // Copy construction
        public Bike(Bike newBike)
        {
            this.serial_number = newBike.serial_number;
            this.make = newBike.make;
            this.speed = newBike.speed;
            this.color = newBike.color;
            this.date = newBike.date;
        }

        //constructor with parameters
        public Bike(long serial_number, string make, double speed, EnumColor color, DateTime date)
        {
            this.serial_number = serial_number;
            this.make = make;
            this.speed = speed;
            this.color = color;
            this.date = date;
        }



        //########################################################
        //Interface Methods
        //########################################################

        public virtual double GetMaxSpeed()
        {

            this.speed = 20;
            return speed;
        }

        public abstract void SpeedUp(double newSpeed);

    }
}
