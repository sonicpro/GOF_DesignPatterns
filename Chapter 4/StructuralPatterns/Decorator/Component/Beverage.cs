using Decorator.Interfaces;

namespace Decorator.Component
{
    abstract class Beverage : IBeverage
    {
        private bool HasMilk { get; }

        private bool HasSoy { get; }

        private bool HasMocha { get; }

        private bool HasWhip { get; }
        
        public Beverage(bool hasMilk = false, bool hasSoy = false, bool hasMocha = false, bool hasWhip = false)
        {
            HasMilk = hasMilk;
            HasSoy = hasSoy;
            HasMocha = hasMocha;
            HasWhip = hasWhip;
        }

        public virtual double Cost()
        {
            double cost = 0;

            if (HasMilk)
            {
                cost += 1;
            }
            if (HasSoy)
            {
                cost += 1.5;
            }
            if (HasMocha)
            {
                cost += 2;
            }
            if (HasWhip)
            {
                cost += 1.8;
            }
            return cost;
        }
    }
}
