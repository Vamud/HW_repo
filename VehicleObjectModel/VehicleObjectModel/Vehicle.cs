// <auto-generated />

using System;
using System.Collections.Generic;

namespace VehicleObjectModel
{
     public abstract class Vehicle : IComparable<Vehicle>
    {
        public int speed { get; set; }
        public int weight { get; set; }
        public string countryProdaction { get; set; }

        public Vehicle(int speed, int weight, string country)
        {
            this.speed = speed;
            this.weight = weight;
            this.countryProdaction = country;
        }

        public abstract void ShowInfo();

        public int CompareTo(Vehicle obj)
        {
            return speed - obj.speed;
        }
    }
}
