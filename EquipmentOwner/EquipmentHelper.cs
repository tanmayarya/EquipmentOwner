using System;
using System.Collections.Generic;

namespace EquipmentOwner
{
    public class EquipmentHelper
    {
        static private Dictionary<string, Equipment> equipments = new Dictionary<string, Equipment>();


        static EquipmentRepository element = new EquipmentRepository();

        public static void CreateEquipment(string name,string description)
        { 


            if(IsMobile())
            {
                Console.WriteLine("Enter number of wheels");
                int wheels = Convert.ToInt32(Console.ReadLine());
                Equipment obj = new Mobile(name, description, wheels);
                element.Create(obj);
            }
            else {
                

                Console.WriteLine("Enter Weight");
                double weight = Convert.ToDouble(Console.ReadLine());
                ImMobile obj = new ImMobile(name, description,weight );
                element.Create(obj);
            }
            Console.WriteLine("Equipment Created");
            Console.WriteLine();

        }



        public static void DeleteEquipment(string name)
        {
            Console.WriteLine();
            if (!element.ContainsEquipment(name))
              Console.WriteLine("Equipment not found");

            else
                Console.WriteLine("{0} deleted" ,name);

        }



        public static void MoveEquipment(string name, double distancemoved)
        {
            Console.WriteLine();
            if (equipments.ContainsKey(name)) 
            {
                equipments.GetValueOrDefault(name).MovedBy(distancemoved);
                Console.WriteLine("{0} moved by {1} Km." ,name,distancemoved);

            }
            else Console.WriteLine("Equipment not found");
        }



        public static void ListEquipment()
        {
            Console.WriteLine();
            Console.WriteLine("--------------Equipments--------------");
            Console.WriteLine();
            Console.WriteLine("Name \t \t Description");
            Console.WriteLine();
            foreach (var item in equipments)
            {
                Console.WriteLine("{0} \t \t {1}", item.Key, item.Value.description);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
        }




        public static void EquipmentDetail(string name)
        {
            Console.WriteLine();
            if (equipments.ContainsKey(name))
            {

                Console.WriteLine("Name: " + equipments.GetValueOrDefault(name).name);
                Console.WriteLine("Description: " + equipments.GetValueOrDefault(name).description);
                Console.WriteLine("Distance Moved: " + equipments.GetValueOrDefault(name).distanceMoved);
                Console.WriteLine("Maintenance Cost: " + equipments.GetValueOrDefault(name).maintenanceCost);

            }
            else Console.WriteLine("Equipment not found");

        }

        public static bool IsMobile()
        {
            int ch;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter type:");
                Console.WriteLine("1. Mobile");
                Console.WriteLine("2. ImMobile");
                string userInput = Console.ReadLine();
                ch = Convert.ToInt32(userInput);
                if (ch > 2)
                    Console.WriteLine("Enter correct choice");

            } while (ch > 2);
            Console.WriteLine();

            return ch == 1;

        }



    }
}
