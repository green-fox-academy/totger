using System;
namespace CounterApp.Models
{
    public class Counter
    {
        public int Number { get; set; } = 1;

        public void Increase()
        {
            Number++;
        }
    }
}
