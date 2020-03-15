using System;
using System.Collections.Generic;
using Visitor.Interfaces;

namespace Visitor.Component
{
    public abstract class Equipment
    {
        public int NetPrice { get; }

        public string Name { get; }

        public Equipment(string name, int netPrice = default)
        {
            Name = name;
            this.NetPrice = netPrice;
        }

        protected List<Equipment> equipment = new List<Equipment>();

        public virtual void Add(Equipment newEquipment)
        {
            equipment.Add(newEquipment);
        }

        public virtual void Remove(Equipment equipment)
        {
            this.equipment.Remove(equipment);
        }

        public abstract void Accept(IEquipmentVisitor visitor);
    }
}
