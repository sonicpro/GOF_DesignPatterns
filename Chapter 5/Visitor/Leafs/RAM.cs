using Visitor.Component;
using Visitor.Interfaces;

namespace Visitor.Leafs
{
    public class RAM : Equipment
    {
        public RAM(string name, int netPrice) : base(name, netPrice)
        {
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            visitor.VisitRAM(this);
        }
    }
}
