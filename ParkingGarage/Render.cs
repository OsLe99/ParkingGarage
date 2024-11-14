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
            int spot = 0;
            foreach (Vehicle vehicle in ParkingSpace.CurrentVehicles)
            {
                spot++;
                Console.WriteLine($"{spot} {vehicle.GetType().Name} Färg: {vehicle.Color} Regplåt: {vehicle.RegNumber} Storlek: {vehicle.Size}");
            }
        }
    }
}
