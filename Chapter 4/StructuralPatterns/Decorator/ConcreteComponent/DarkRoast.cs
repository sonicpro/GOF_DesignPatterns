using Decorator.Interfaces;

namespace Decorator.ConcreteComponent
{
    class DarkRoast : IBeverage
    {
        public double Cost()
        {
            return 13;
        }
    }
}
