using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_13___Classes_Types
{
    abstract class VehicleBase
    {
        public int NumOfWheels { get; set; }
        public string Model { get; set; }

        protected VehicleBase(int numOfWheels, string model)
        {
            NumOfWheels = numOfWheels;
            Model = model;
        }

        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();
        public override string ToString()
        {
            return NumOfWheels + " wheels. Model: " + Model + ".";
        }
    }
    class Car : VehicleBase
    {
        public int NumOfDoors { get; set; }

        public Car(int numOfWheels, string model, int numOfDoors) : base(numOfWheels, model)
        {
            NumOfDoors = numOfDoors;
        }

        public override int GetMaxNumOfPassengers()
        {
            return 5;
        }

        public override int GetMaxSpeed()
        {
            return 250;
        }
        public override string ToString()
        {
            return base.ToString() + $" {NumOfDoors} doors.";
        }
    }
    class Motorcycle : VehicleBase
    {
        public int NumOfHandBrakes { get; set; }

        public Motorcycle(int numOfWheels, string model, int numOfHandBrakes) : base(numOfWheels, model)
        {
            NumOfHandBrakes = numOfHandBrakes;
        }

        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 180;
        }
        public override string ToString()
        {
            return base.ToString() + $" {NumOfHandBrakes} hand-brakes.";
        }
    }
    class Carrier
    {
        public VehicleBase[] Vehicles { get; set; }

        public Carrier(params VehicleBase[] vehicles)
        {
            Vehicles = vehicles;
        }
        public override string ToString()
        {
            string a = "";
            for (int i = 0; i < Vehicles.Length; i++)
            {
                a += Vehicles[i].ToString() + "\n";
            }
            return a;
        }
    }
}
