using System;

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
        public int Code;

        public Car(Type type, Color color)
        {
            Type = type;
            Color = color;

            SetCode();
        }

        private void SetCode()
        {
            int code = 0;
            for (int i = 0; i < Enum.GetNames(typeof(Type)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Color)).Length; j++)
                {
                    if (Color == (Color)j && Type == (Type)i)
                    {
                        Code = code;
                        return;
                    }
                    code++;
                }
            }
        }
    }
}
