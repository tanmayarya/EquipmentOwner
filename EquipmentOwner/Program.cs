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
                        EquipmentOpertion.Create();
                        break;
                    case Choice.Delete:
                        EquipmentOpertion.Delete();
                        break;
                    case Choice.Move:
                        EquipmentOpertion.Move();
                        break;
                    case Choice.ListAll:
                        EquipmentOpertion.ListAll();
                        break;

                    case Choice.EquipmentDetails:
                        EquipmentOpertion.EquipmentDetail();
                        break;

                    case Choice.Exit:
                        InputOutput.Exit();
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
