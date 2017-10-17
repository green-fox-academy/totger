using System;
namespace StringedInstruments
{
    public abstract class Instrument
    {
        protected string instrumentName;

        public abstract void Play();
    }
}
