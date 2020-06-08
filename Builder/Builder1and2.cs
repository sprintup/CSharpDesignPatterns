using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Builder1and2
    {
        public static void Run()
        {
            VehicleBuilder builder;

            Shop shop = new Shop();


            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
        }
    }
    class Shop
    {
        public void Construct(VehicleBuilder vb)
        {
            vb.BuildFrame();
            vb.BuildEngine();
            vb.BuildWheels();
            vb.BuildDoors();
        }
    }

    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }

    class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("Motorcycle");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }

    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }

    class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            vehicle = new Vehicle("scooter");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "ScooterFrame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "50 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n-------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine("Frame: {0}", _parts["frame"]);
            Console.WriteLine("Engine: {0}", _parts["engine"]);
            Console.WriteLine("#Wheels: {0}", _parts["wheels"]);
            Console.WriteLine("#Doors: {0}", _parts["doors"]);
        }
    }
}
