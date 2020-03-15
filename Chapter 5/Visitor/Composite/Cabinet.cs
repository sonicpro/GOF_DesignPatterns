using Visitor.Component;
using Visitor.Interfaces;

namespace Visitor.Composite
{
    public class Cabinet : Equipment
    {
        public Cabinet(string name, int netPrice) : base(name, netPrice)
        {
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            equipment.ForEach(e => e.Accept(visitor));
            visitor.VisitCabinet(this);
        }
    }
}
