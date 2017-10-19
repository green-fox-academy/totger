using System;

namespace ParkingLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CarParking parkolo = new CarParking();
            parkolo.FillLot();
            Console.WriteLine(parkolo.parkingLot[28].Color);
        }
    }
}
