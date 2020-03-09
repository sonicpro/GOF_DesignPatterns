using Composite.Component;

namespace Composite.Composite
{
    class Cabinet : Equipment
    {
        public Cabinet(string name, int netPrice) : base(name, netPrice)
        {
        }

        public override int Power => 0;
    }
}
