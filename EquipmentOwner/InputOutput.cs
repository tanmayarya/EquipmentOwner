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

        public static void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you");

        }

        public static string GetStringInput(String message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void PrintLine(String message)
        {
            Console.WriteLine(message);
        }

        public static double GetDoubleInput(String message)
        {
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static int GetIntInput(String message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
