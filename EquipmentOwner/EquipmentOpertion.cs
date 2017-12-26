using System;
namespace EquipmentOwner
{
    public class EquipmentOpertion
    {
        public static void Create()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Description:");
            string description = Console.ReadLine();
            EquipmentHelper.CreateEquipment(name, description);
        }

        public static void Delete()
        {
            Console.WriteLine();
            Console.WriteLine("Enter name of the Equipment:");
            String name = Console.ReadLine();

            EquipmentHelper.DeleteEquipment(name);
        }

        public static void Move()
        {
            Console.WriteLine();
            Console.WriteLine("Enter name of the Equipment:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter distance to be moved:");
            double distancemoved = Convert.ToDouble(Console.ReadLine());
            EquipmentHelper.MoveEquipment(name, distancemoved);
        }

        public static void ListAll()
        {
            Console.WriteLine();
            EquipmentHelper.ListEquipment();
        }
    }
}
