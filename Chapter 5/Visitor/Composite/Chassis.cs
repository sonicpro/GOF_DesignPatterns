using Visitor.Component;
using Visitor.Interfaces;

namespace Visitor.Composite
{
    public class Chassis : Equipment
    {
        public Chassis(string name, int netPrice) : base(name, netPrice)
        {
        }

        public override void Accept(IEquipmentVisitor visitor)
        {
            equipment.ForEach(e => e.Accept(visitor));
            visitor.VisitChassis(this);
        }
    }
}
