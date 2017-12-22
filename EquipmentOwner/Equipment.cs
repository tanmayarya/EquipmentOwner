using System;
using System.Collections.Generic;

namespace EquipmentOwner
{
    public class Equipment
    {
        public string name { get; private set; }
        public string description{ get; private set; }
        public double distanceMoved{ get; protected set; }
        public double maintenanceCost{ get; protected set; }




        public Equipment(string name,string description)
        {
            this.name = name;
            this.description = description;
            this.distanceMoved = 0;
            this.maintenanceCost = 0;
        }

        public virtual void MovedBy(double distance){
            this.distanceMoved += distance;
        }

       
     }
}
