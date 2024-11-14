using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    internal class Helpers
    {
        public static string GenerateRandomReg()
        {
            Random random = new Random();
            string letters = "";

            for (int i = 0; i < 3; i++)
            {
                letters += (char)('A' + random.Next(0, 26));
            }

            string numbers = "";
            for (int i = 0; i < 3; i++)
            {
                numbers += random.Next(0, 10);
            }

            string regNumber = letters + numbers;

            return regNumber;
        }

        public static string GenerateColor()
        {
            int random = Random.Shared.Next(0, 2);
            string color = "";
            if (random == 0)
            {
                color += "röd";
            }
            else if (random == 1)
            {
                color += "blå";
            }
            else
            {
                color += "grön";
            }

            return color;
        }

        public static bool GenerateBool()
        {
            int random = Random.Shared.Next(0, 2);

            if (random == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string GenerateBrand()
        {
            int random = Random.Shared.Next(0, 3);
            string brand = "";

            if (random == 0)
            {
                brand += "Harley";
            }
            else if (random == 1)
            {
                brand += "Yamaha";
            }
            else
            {
                brand += "Suzuki";
            }
            
            return brand;
        }

        public static int GeneratePassengers()
        {
            int passengerAmount = Random.Shared.Next(1, 25);

            return passengerAmount;
        }
    }
}
