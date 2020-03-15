using Visitor.Component;
using Visitor.Interfaces;

namespace Visitor.Leafs
{
    public class M2SSD : Equipment
    {
        public M2SSD(string name, int netPrice) : base(name, netPrice)
        {
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            visitor.VisitM2SSD(this);
        }
    }
}
