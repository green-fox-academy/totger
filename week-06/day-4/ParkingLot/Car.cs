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
        
        public int Code;
        public Type Type;
        public Color Color;

        public Car(Type type, Color color)
        {
            Type = type;
            Color = color;

            SetCode();
        }

        private void SetCode()
        {
            int code = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
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
