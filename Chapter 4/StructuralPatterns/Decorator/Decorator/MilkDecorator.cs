using Decorator.Interfaces;

namespace Decorator.Decorator
{
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 1;
        }
    }
}
