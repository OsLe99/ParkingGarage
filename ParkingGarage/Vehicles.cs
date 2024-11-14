using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public string RegNumber { get; set; }
        public int Ticket { get; set; }
        public double Size { get; set; }

        public Vehicle (string color, string regNumber, int ticket, double size)
        {
            Color = color;
            RegNumber = regNumber;
            Ticket = ticket;
            Size = size;
        }
    }

    class Motorbike : Vehicle
    {
        public string Brand { get; set; }

        public Motorbike(string color, string regNumber, string brand, int ticket, double size) : base(color, regNumber, ticket, size)
        {
            Brand = brand;
            Size = size;
        }
    }

    class Car : Vehicle
    {
        public bool IsElectric { get; set; }

        public Car(string color, string regNumber, bool isElectric, int ticket, double size) : base(color, regNumber, ticket, size)
        {
            IsElectric = isElectric;
            Size = size;
        }
    }

    class Bus : Vehicle
    {
        public int PassengerAmount { get; set; }

        public Bus(string color, string regNumber, int passengerAmount, int ticket, double size) : base(color, regNumber, ticket, size)
        {
            PassengerAmount = passengerAmount;
            Size = size;
        }
    }
}
