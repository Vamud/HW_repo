﻿// <auto-generated />

using System;
using System.Collections.Generic;

namespace VehicleObjectModel
{
    public class FamilyCar : Car
    {
        public int numberOfSeats { get; set; }

        public FamilyCar(int spead, int weight, string country, string fuel, int seats)
            :base(spead, weight, country, fuel)
        {
            numberOfSeats = seats;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Minivan. Скорость:{speed}, Масса: {weight}, вид топлива: {fuelType}, посадочных мест: {numberOfSeats}");
        }

        public override void Move()
        {
            Console.WriteLine("Я никуда не спешу");
        }
    }
}