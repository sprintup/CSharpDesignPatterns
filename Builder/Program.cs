using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! builder");
            VehicleBuilder builder;

            Shop shop = new Shop();
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            //wait for user
            Console.ReadKey();
        }

        class Shop
        {
            public void Construct(VehicleBuilder vb)
            {
                vb.BuildFrame();
            }
        }

        abstract class VehicleBuilder
        {
            protected Vehicle vehicle;

            public Vehicle Vehicle
            {
                get { return vehicle;  }
            }

            public abstract void BuildFrame();
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
            }
        }
    }
}
