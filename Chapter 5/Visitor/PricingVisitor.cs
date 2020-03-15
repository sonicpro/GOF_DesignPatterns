using Visitor.Component;
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
            VisitFixedPriceEquipment(cabinet);
        }

        public void VisitChassis(Chassis chassis)
        {
            VisitFixedPriceEquipment(chassis);
        }

        public void VisitM2SSD(M2SSD m2ssd)
        {
            VisitFixedPriceEquipment(m2ssd);
        }

        public void VisitRAM(RAM ram)
        {
            VisitFixedPriceEquipment(ram);
        }

        #region Helper methods

        public void VisitFixedPriceEquipment(Equipment equipment)
        {
            TotalPrice += equipment.NetPrice;
        }

        #endregion
    }
}
