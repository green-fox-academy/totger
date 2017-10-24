using System;

namespace ParkingLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CarParking parkolo = new CarParking();
            parkolo.FillLot(1000);
            parkolo.PrintGroups();
            parkolo.PrintMostCommonCar();
        }
    }
}
