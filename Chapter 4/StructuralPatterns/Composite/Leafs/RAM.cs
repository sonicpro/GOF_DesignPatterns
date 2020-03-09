using Composite.Component;

namespace Composite.Leafs
{
    class RAM : Equipment
    {
        public RAM(string name) : base(name)
        {
        }

        public override int Power => 5;

        public override int NetPrice => 40;
    }
}
