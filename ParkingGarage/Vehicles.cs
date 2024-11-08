using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string RegNumber { get; set; }
        public int Ticket { get; set; }

        public Vehicle (string color, string regNumber, int ticket)
        {
            Color = color;
            RegNumber = regNumber;
            Ticket = ticket;
        }
    }

    class Motorbike : Vehicle
    {
        public string Brand { get; set; }

        public Motorbike(string color, string regNumber, string brand, int ticket) : base(color, regNumber, ticket)
        {
            Brand = brand;
        }
    }

    class Car : Vehicle
    {
        public bool IsElectric { get; set; }

        public Car(string color, string regNumber, bool isElectric, int ticket) : base(color, regNumber, ticket)
        {
            IsElectric = isElectric;
        }
    }

    class Bus : Vehicle
    {
        public int PassengerAmount { get; set; }

        public Bus(string color, string regNumber, int passengerAmount, int ticket) : base(color, regNumber, ticket)
        {
            PassengerAmount = passengerAmount;
        }
    }
}
