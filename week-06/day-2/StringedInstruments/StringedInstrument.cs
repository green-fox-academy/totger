using System;
namespace StringedInstruments
{
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine($"{instrumentName}, a {numberOfStrings}-string instrument, that {Sound()}s");
        }
    }
}
