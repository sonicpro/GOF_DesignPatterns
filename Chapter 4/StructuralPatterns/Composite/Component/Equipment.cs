using System.Collections.Generic;
using System.Linq;

namespace Composite.Component
{
    public abstract class Equipment
    {
        private readonly int netPrice = 0;

        public string Name { get; }

        public Equipment(string name, int netPrice = default)
        {
            Name = name;
            this.netPrice = netPrice;
        }

        private List<Equipment> equipment = new List<Equipment>();

        public abstract int Power { get; }

        public virtual int NetPrice => equipment.Sum(e => e.NetPrice) + netPrice;

        public virtual void Add(Equipment newEquipment)
        {
            equipment.Add(newEquipment);
        }

        public virtual void Remove(Equipment equipment)
        {
            this.equipment.Remove(equipment);
        }
    }
}
