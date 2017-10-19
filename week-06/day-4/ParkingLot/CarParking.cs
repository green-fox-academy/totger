﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        public void PrintNumberOfSameStuff()
        {

            var sameType = parkingLot.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count());
            foreach (var type in sameType)
            {
                Console.WriteLine(type);
            }

            var sameColor = parkingLot.GroupBy(x => x.Color).ToDictionary(x => x.Key, x => x.Count());
            foreach (var type in sameColor)
            {
                Console.WriteLine(type);
            }
        }
        public void PrintMostCommonColorOfMostCommonType()
        {
            var mostCommon = parkingLot.GroupBy(x => x.Type)
                                       .OrderByDescending(x => x.Count())
                                       .Select(x => x).First()
                                       .GroupBy(x => x.Color)
                                       .OrderByDescending(x => x.Count())
                                       .Select(x => x).First();
            Console.WriteLine($"{mostCommon.First().Color}  {mostCommon.First().Type}");
        }
    }
}
