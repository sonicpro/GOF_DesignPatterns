using Composite.Component;

namespace Composite.Leafs
{
    class M2SSD : Equipment
    {
        public M2SSD(string name) : base(name)
        {
        }

        public override int Power => 5;

        public override int NetPrice => 50;
    }
}
