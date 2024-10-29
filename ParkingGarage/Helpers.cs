using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage
{
    internal class Helpers
    {
        public static string GenerateRandomReg(string regNumber)
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

            regNumber = letters + numbers;

            return regNumber;

        }
    }
}
