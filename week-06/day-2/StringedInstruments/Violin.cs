using System;
namespace StringedInstruments
{
    public class Violin : StringedInstrument
    {
        public Violin()
        {
            numberOfStrings = 4;
            instrumentName = "Violin";
        }

        public Violin(int strings)
        {
            numberOfStrings = strings;
            instrumentName = "Violin";
        }

        public override string Sound()
        {
            return "screech";
        }
    }
}