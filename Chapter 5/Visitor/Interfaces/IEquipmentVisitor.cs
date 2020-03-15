using Visitor.Composite;
using Visitor.Leafs;

namespace Visitor.Interfaces
{
    // This interface is supposed to be stable, i.e. the hierarchy of Composites + Components are not going to expand.
    public interface IEquipmentVisitor
    {
        void VisitCabinet(Cabinet cabinet);

        void VisitChassis(Chassis chassis);

        void VisitM2SSD(M2SSD m2ssd);

        void VisitRAM(RAM ram);
    }
}
