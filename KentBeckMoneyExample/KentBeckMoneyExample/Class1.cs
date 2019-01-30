using System;

namespace KentBeckMoneyExample
{
    public class Dollar : ICloneable
    {
        public int amount;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Dollar(int amount) //class constructor
        {
            this.amount = amount;
        }

        public void times(int multiplier)
        {
            amount = amount * multiplier;
        }
    }
}
