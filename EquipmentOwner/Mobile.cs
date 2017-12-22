using System;
namespace EquipmentOwner
{
    public class Mobile : Equipment
    {
        protected int wheels;

        public Mobile(string name, string description, int wheels) : base(name, description)
        {
            this.wheels = wheels;
        }

        public override void MovedBy(double distance)
        {
            base.MovedBy(distance);
            this.maintenanceCost += (this.wheels * this.distanceMoved);
        }
    }
}
