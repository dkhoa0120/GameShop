using System;
namespace GameShop
{
    class IO
    {
        public static int EnterMenuOptions()
        {
            Console.WriteLine("\n**********Game Store*********");
            Console.WriteLine("=============================");
            Console.WriteLine("1: Add new Games");
            Console.WriteLine("2: Display all Games");
            Console.WriteLine("3: Display Games by name");
            Console.WriteLine("4: Remove Game by id");
            Console.WriteLine("5: Update Game by id");
            Console.WriteLine("=============================\n");
            Console.Write("Enter your choice:  \n");
            return int.Parse(Console.ReadLine());
        }
        public static string EnterGame()
        {
            Console.WriteLine("\n===========================================");
            Console.WriteLine("Enter \"n\" for normal Game");
            Console.WriteLine("Enter \"g\" for Golden Edition Game - DLC");
            Console.WriteLine("Enter \"r\" to return main menu");
            Console.WriteLine("===========================================\n");
            Console.Write("Enter your choice:  ");
            return Console.ReadLine();
        }
        public static int EnterId()
        {
            
            Console.Write("Enter ID:     ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        public static string EnterTitle()
        {
            Console.Write("Enter title:  ");
            string title = Console.ReadLine();
            return title;
        }
        public static string EnterStudio()
        {
            Console.Write("Enter studio: ");
            string author = Console.ReadLine();
            return author;
        }
        public static double EnterPrice()
        {
            Console.Write("Enter price:  ");
            double price = double.Parse(Console.ReadLine());
            return price;
        }
        public static int EnterQuantity()
        {
            Console.Write("Enter quantity:  ");
            int quantity = int.Parse(Console.ReadLine());
            return quantity;
        }
        public static string ShowMessage(bool result)
        {
            if (!result) return "FAILED!!!!!!";
            return "SUCCESSFULLY!!!";
        }
        public static void ToScreen(string str)
        {
            Console.WriteLine(str);
        }
    }
}

