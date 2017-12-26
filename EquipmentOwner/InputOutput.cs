using System;
namespace EquipmentOwner
{
    public class InputOutput
    {
        public InputOutput()
        {
        }

        public static void ShowMenu()
        {
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
          
        }

        public static Choice Choice()
        {
            Console.WriteLine("Enter choice number:");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return (Choice)choice;
        }

    }
}
