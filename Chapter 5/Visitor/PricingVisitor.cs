using Visitor.Composite;
using Visitor.Interfaces;
using Visitor.Leafs;

namespace Visitor
{
    class PricingVisitor : IEquipmentVisitor
    {
        public int TotalPrice { get; private set; }

        public void VisitCabinet(Cabinet cabinet)
        {
            TotalPrice += cabinet.NetPrice;
        }

        public void VisitChassis(Chassis chassis)
        {
            TotalPrice += chassis.NetPrice;
        }

        public void VisitM2SSD(M2SSD m2ssd)
        {
            TotalPrice += m2ssd.NetPrice;
        }

        public void VisitRAM(RAM ram)
        {
            TotalPrice += ram.NetPrice;
        }
    }
}
