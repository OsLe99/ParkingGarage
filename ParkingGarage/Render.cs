using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    internal class Render
    {
        public static void DrawParking()
        {
            foreach (Vehicle vehicle in ParkingSpace.CurrentVehicles)
            {
                Console.WriteLine($"{vehicle.GetType().Name} Färg: {vehicle.Color} Regplåt: {vehicle.RegNumber}");
            }
        }
    }
}
