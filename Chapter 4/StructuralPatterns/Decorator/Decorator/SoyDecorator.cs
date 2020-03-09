using Decorator.Interfaces;

namespace Decorator.Decorator
{
    public class SoyDecorator : BeverageDecorator
    {
        public SoyDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 1.5;
        }
    }
}
