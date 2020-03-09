using Decorator.Interfaces;

namespace Decorator.Decorator
{
    public class WhipDecorator : BeverageDecorator
    {
        public WhipDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 1.8;
        }
    }
}
