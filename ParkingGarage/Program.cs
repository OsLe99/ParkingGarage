namespace ParkingGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSpace parkingSpace = new ParkingSpace(15, new List<Vehicle>());

            while (true)
            {
                parkingSpace.SpawnVehicle();
                Render.DrawParking();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
