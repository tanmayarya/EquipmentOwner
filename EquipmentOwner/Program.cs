using System;
using System.Collections.Generic;

namespace EquipmentOwner
{
    class Program
    {


        static void Main(string[] args)
        {

            Choice choice;
            do
            {
                InputOutput.ShowMenu();
                choice = InputOutput.Choice();
                switch (choice)
                {
                    case Choice.Create:
                        Console.WriteLine();
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Description:");
                        string description = Console.ReadLine();

                        EquipmentHelper.CreateEquipment(name, description);
                        break;

                    case Choice.Delete:
                        Console.WriteLine();
                        Console.WriteLine("Enter name of the Equipment:");
                        name = Console.ReadLine();

                        EquipmentHelper.DeleteEquipment(name);
                        break;
                    case Choice.Move:
                        Console.WriteLine();
                        Console.WriteLine("Enter name of the Equipment:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter distance to be moved:");
                        double distancemoved = Convert.ToDouble(Console.ReadLine());
                        EquipmentHelper.MoveEquipment(name, distancemoved);
                        break;

                    case Choice.ListAll:
                        Console.WriteLine();
                        EquipmentHelper.ListEquipment();
                        break;

                    case Choice.EquipmentDetails:
                        Console.WriteLine();
                        Console.WriteLine("Enter name of the Equipment:");
                        name = Console.ReadLine();
                        EquipmentHelper.EquipmentDetail(name);
                        break;

                    case Choice.Exit:
                        Console.WriteLine();
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Enter valid choice");
                        break;
                }

            } while (choice != Choice.Exit);


        }
    }

}
