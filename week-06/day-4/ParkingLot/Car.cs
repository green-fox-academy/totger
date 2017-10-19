using System;
using System.Collections.Generic;
namespace ParkingLot
{
    public enum Type
    {
        Moskvitch,
        Opel,
        Ferrari,
        Renault,
        Toyota
    };

    public enum Color
    {
        Black,
        White,
        Pink,
        Red,
        Silver
    };

    public class Car
    {
        
        public Type Type;
        public Color Color;

        public Car(Type type, Color color)
        {
            Type = type;
            Color = color;
        }
    }
}
