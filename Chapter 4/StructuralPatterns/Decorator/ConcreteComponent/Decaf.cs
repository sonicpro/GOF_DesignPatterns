using Decorator.Interfaces;

namespace Decorator.ConcreteComponent
{
    class Decaf : IBeverage
    {
        public double Cost()
        {
            return 18;
        }
    }
}
