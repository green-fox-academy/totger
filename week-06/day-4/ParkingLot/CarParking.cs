using System;
using System.Collections.Generic;
namespace ParkingLot
{
    public class CarParking
    {
        Random random = new Random();
        public List<Car> parkingLot = new List<Car>();

        public CarParking()
        {
        }

        public void FillLot()
        {
            for (int i = 0; i < 256; i++)
            {
                parkingLot.Add(new Car((Type)random.Next(0, 5), (Color)random.Next(0, 5)));
            }
        }
    }
}
