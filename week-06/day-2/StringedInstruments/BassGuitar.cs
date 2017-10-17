using System;
namespace StringedInstruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            numberOfStrings = 4;
            instrumentName = "Bass Guitar";
        }

        public BassGuitar(int strings)
        {
            numberOfStrings = strings;
            instrumentName = "Bass Guitar";
        }

        public override string Sound()
        {
            return "duum-duum-duum";
        }
    }
}