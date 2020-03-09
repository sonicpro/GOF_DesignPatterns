using Composite.Component;

namespace Composite.Composite
{
    class Chassis : Equipment
    {
        public Chassis(string name, int netPrice) : base(name, netPrice)
        {
        }

        public override int Power => 20;
    }
}
