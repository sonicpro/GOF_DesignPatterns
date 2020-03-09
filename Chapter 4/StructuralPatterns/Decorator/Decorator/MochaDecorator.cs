using Decorator.Interfaces;

namespace Decorator.Decorator
{
    public class MochaDecorator : BeverageDecorator
    {
        public MochaDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 2;
        }
    }
}
