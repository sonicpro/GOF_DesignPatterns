using Decorator.Interfaces;

namespace Decorator.Decorator
{
    public abstract class BeverageDecorator : IBeverage
    {
        private readonly IBeverage beverage;

        public BeverageDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public virtual double Cost()
        {
            return beverage.Cost();
        }
    }
}
