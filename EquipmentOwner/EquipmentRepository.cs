using System;
using System.Collections.Generic;

namespace EquipmentOwner
{
    public class EquipmentRepository
    {
        private Dictionary<string, Equipment> Equipments = new Dictionary<string, Equipment>();

        public void Create(Equipment equipment)
        {
            if (!ContainsEquipment(equipment))
                Equipments.Add(equipment.name, equipment);
        }

        public bool Delete(Equipment equipment)
        {
            if (ContainsEquipment(equipment))
            {
                Equipments.Remove(equipment.name);
                return true;
            }
            return false;
        }

        public bool ContainsEquipment(Equipment equipment)
        {
            return Equipments.ContainsValue(equipment);
        }

        public bool ContainsEquipment(String equipment)
        {
            return Equipments.ContainsKey(equipment);
        }

        public Equipment GetEquipment(String name)
        {
            return Equipments.GetValueOrDefault(name);
        }

        public Dictionary<string, Equipment> GetAllEquipments()
        {
            return this.Equipments;
        }
    }
}
