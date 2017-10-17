using System;
namespace StringedInstruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
            instrumentName = "Electric Guitar";
        }

        public ElectricGuitar(int strings)
        {
            numberOfStrings = strings;
            instrumentName = "Electric Guitar";
        }

        public override string Sound()
        {
            return "twang";
        }
    }
}
