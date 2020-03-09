using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    class DecafFirstAttempt : Beverage
    {
        public DecafFirstAttempt(bool hasMilk = false, bool hasSoy = false, bool hasMocha = false, bool hasWhip = false)
            : base(hasMilk, hasSoy, hasMocha, hasWhip)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 18;
        }
    }
}
