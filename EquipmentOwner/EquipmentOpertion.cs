using System;
using System.Collections.Generic;

namespace EquipmentOwner
{
    public class EquipmentOpertion
    {
        static EquipmentRepository equimentRepo = new EquipmentRepository();

        public static void Create()
        {
            InputOutput.PrintLine("");
            string name = InputOutput.GetStringInput("Enter Name:");
            string description = InputOutput.GetStringInput("Enter Description:");

            if (InputOutput.IsMobile())
            {
                int wheels = InputOutput.GetIntInput("Enter number of wheels");
                Equipment obj = new Mobile(name, description, wheels);
                equimentRepo.Create(obj);
            }
            else
            {
                double weight = InputOutput.GetDoubleInput("Enter Weight");
                ImMobile obj = new ImMobile(name, description, weight);
                equimentRepo.Create(obj);
            }
            InputOutput.PrintLine("Equipment Created");
            InputOutput.PrintLine("");
        }

        public static void Delete()
        {
            InputOutput.PrintLine("");
            string name = InputOutput.GetStringInput("Enter Name of the Equipment:");
            InputOutput.PrintLine("");
            if (!equimentRepo.ContainsEquipment(name))
                InputOutput.PrintLine("Equipment not found");

            else
            {
                equimentRepo.Delete(equimentRepo.GetEquipment(name));
                InputOutput.PrintLine(string.Format("{0} deleted", name));
            }
        }

        public static void Move()
        {
            InputOutput.PrintLine("");
            string name = InputOutput.GetStringInput("Enter Name of the Equipment:");
            double distancemoved = InputOutput.GetDoubleInput("Enter distance to be moved: ");
           

            Console.WriteLine();
            if (equimentRepo.ContainsEquipment(name) )
            {
                equimentRepo.GetEquipment(name).MovedBy(distancemoved);
                InputOutput.PrintLine(string.Format("{0} moved by {1} Km.", name, distancemoved));

            }
            else InputOutput.PrintLine("Equipment not found");
        }

        public static void ListAll()
        {
            InputOutput.PrintLine("");


            InputOutput.PrintLine("--------------Equipments--------------");
            InputOutput.PrintLine("");
            InputOutput.PrintLine("Name \t \t Description");
            InputOutput.PrintLine("");
            Dictionary<string, Equipment> equipments = equimentRepo.GetAllEquipments();
            foreach (var item in equipments)
            {
                InputOutput.PrintLine(string.Format("{0} \t \t {1}", item.Key, item.Value.description));
            }

            InputOutput.PrintLine("--------------------------------------");
      
        }

        public static void EquipmentDetail()
        {
            InputOutput.PrintLine("");
            string name = InputOutput.GetStringInput("Enter Name of the Equipment:");

            InputOutput.PrintLine("");
            if (equimentRepo.ContainsEquipment(name))
            {
                Equipment equipment = equimentRepo.GetEquipment(name);
                InputOutput.PrintLine("Name: " + equipment.name);
                InputOutput.PrintLine("Description: " + equipment.description);
                InputOutput.PrintLine("Distance Moved: " + equipment.distanceMoved);
                InputOutput.PrintLine("Maintenance Cost: " + equipment.maintenanceCost);

            }
            else InputOutput.PrintLine("Equipment not found");

        }

    }
}
