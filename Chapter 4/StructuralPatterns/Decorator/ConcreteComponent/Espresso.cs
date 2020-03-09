using Decorator.Interfaces;

namespace Decorator.ConcreteComponent
{
    class Espresso : IBeverage
    {
        public double Cost()
        {
            return 10;
        }
    }
}
