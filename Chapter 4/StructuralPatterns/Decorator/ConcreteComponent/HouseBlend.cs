using Decorator.Interfaces;

namespace Decorator.ConcreteComponent
{
    class HouseBlend : IBeverage
    {
        public double Cost()
        {
            return 15;
        }
    }
}
