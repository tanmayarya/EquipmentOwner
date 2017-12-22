using System;
using System.Collections.Generic;

namespace EquipmentOwner
{
    class Program 
    {


        static void Main(string[] args)
        {
            
            int choice;
            do { 
                Console.WriteLine();
            Console.WriteLine("******************** WELCOME ********************");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1. Create an Equipment");
            Console.WriteLine("2. Delete an Equipment");
            Console.WriteLine("3. Move an Equipment");
            Console.WriteLine("4. List all Equipments");
            Console.WriteLine("5. Show details of an equipment");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            Console.WriteLine("Enter choice number:");
           
            choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
             
            switch(choice)
            {
                case 1: 
                        
                        Console.WriteLine();
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Description:");
                        string description = Console.ReadLine();

                        EquipmentHelper.CreateEquipment(name, description);
                        break;

                case 2:
                        Console.WriteLine();
                        Console.WriteLine("Enter name of the Equipment:");
                        name = Console.ReadLine();

                        EquipmentHelper.DeleteEquipment(name);
                        break;
                case 3:
                        Console.WriteLine();
                        Console.WriteLine("Enter name of the Equipment:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter distance to be moved:");
                        double distancemoved = Convert.ToDouble(Console.ReadLine());
                        EquipmentHelper.MoveEquipment(name, distancemoved);
                        break;
                case 4:
                        Console.WriteLine();
                        EquipmentHelper.ListEquipment();
                        break;
                case 5:
                        Console.WriteLine();
                        Console.WriteLine("Enter name of the Equipment:");
                        name = Console.ReadLine();
                        EquipmentHelper.EquipmentDetail(name);
                        break;
                case 6:
                        Console.WriteLine();
                        Console.WriteLine("Thank you");
                        break;
                default:
                        Console.WriteLine();
                        Console.WriteLine("Enter valid choice");
                        break;
            }

            } while (choice!=6);


        }
    }

}
