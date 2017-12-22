using System;
using System.Collections.Generic;

namespace EquipmentOwner
{
    public class Equipment
    {

        protected string name;
        protected string description;
        protected double distanceMoved;
        protected double maintenanceCost;




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

       
        public string GetName() {
            return this.name;
        }
       

        public string GetDescription(){
            return this.description;
        }

       

        public double GetDistanceMoved(){
            return this.distanceMoved;
        }
       

        public double GetMaintenanceCost() {
            return this.maintenanceCost;
        }


    }
}
