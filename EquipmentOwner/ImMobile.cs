using System;
namespace EquipmentOwner
{
    public class ImMobile :Equipment
    {
        protected double wieght;

        public ImMobile(string name, string description,double wieght) : base(name, description)
        {
            this.wieght = wieght;
        }

        public override void MovedBy(double distance)
        {
            base.MovedBy(distance);
            this.maintenanceCost += (this.wieght * this.distanceMoved);
        }
    }
}
