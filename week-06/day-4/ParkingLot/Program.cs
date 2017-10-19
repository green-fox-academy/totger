using System;

namespace ParkingLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CarParking parkolo = new CarParking();
            parkolo.FillLot();
            parkolo.PrintNumberOfSameStuff();
            parkolo.PrintMostCommonCar();
        }
    }
}
