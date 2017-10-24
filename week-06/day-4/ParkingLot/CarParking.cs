using System;
using System.Collections.Generic;
using System.Linq;
namespace ParkingLot
{
    public class CarParking
    {
        Random random = new Random();
        public List<Car> parkingLot = new List<Car>();

        public void FillLot(int numberOfCars)
        {
            for (int i = 0; i < numberOfCars; i++)
            {
                parkingLot.Add(new Car((Type)random.Next(0, Enum.GetNames(typeof(Type)).Length),
                                       (Color)random.Next(0, Enum.GetNames(typeof(Color)).Length)));
            }
        }

        public void PrintGroups()
        {

            var sameType = parkingLot.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count());
            foreach (var type in sameType)
            {
                Console.WriteLine(type);
            }
            Console.WriteLine("___________________\n");

            var sameColor = parkingLot.GroupBy(x => x.Color).ToDictionary(x => x.Key, x => x.Count());
            foreach (var type in sameColor)
            {
                Console.WriteLine(type);
            }
            Console.WriteLine("___________________\n");
        }
        public void PrintMostCommonCar()
        {
            var mostCommon = parkingLot.GroupBy(x => x.Code).ToList()
                                       .OrderByDescending(x => x.Count())
                                       .First().First();
            Console.WriteLine($"The most common car is: {mostCommon.Color} {mostCommon.Type}");
        }
    }
}
