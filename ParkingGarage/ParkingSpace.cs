using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    public class ParkingSpace
    {
        public int ParkingSpots { get; }
        public static List<Vehicle> CurrentVehicles { get; set; }

        public ParkingSpace(int parkingSpots, List<Vehicle> currentVehicles)
        {
            ParkingSpots = parkingSpots;
            CurrentVehicles = new List<Vehicle>();
        }
        public void SpawnVehicle()
        {
            int type = Random.Shared.Next(0, 3);
            string regNumber = Helpers.GenerateRandomReg();
            string color = Helpers.GenerateColor();
            bool isElectric = Helpers.GenerateBool();
            string brand = Helpers.GenerateBrand();
            int passengerAmount = Helpers.GeneratePassengers();
            if (type == 0)
            {
                CurrentVehicles.Add(new Car (color, regNumber, isElectric, 0));
            }
            else if (type == 1)
            {
                CurrentVehicles.Add(new Motorbike (color, regNumber, "Harley", 0));
            }
            else
            {
                CurrentVehicles.Add(new Bus(color, regNumber, passengerAmount, 0));
            }

        }
    }
}

