using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public string RegNumber { get; set; }

        public Vehicle (string color, string regNumber)
        {
            Color = color;
            RegNumber = regNumber;
        }
    }

    class Motorbike : Vehicle
    {
        public string Brand { get; set; }

        public Motorbike(string color, string regNumber, string brand) : base(color, regNumber)
        {
            Brand = brand;
        }
    }

    class Car : Vehicle
    {
        public bool IsElectric { get; set; }

        public Car(string color, string regNumber, bool isElectric) : base(color, regNumber)
        {
            IsElectric = isElectric;
        }
    }

    class Bus : Vehicle
    {
        public int PassengerAmount { get; set; }

        public Bus(string color, string regNumber, int passengerAmount) : base(color, regNumber)
        {
            PassengerAmount = passengerAmount;
        }
    }
}
