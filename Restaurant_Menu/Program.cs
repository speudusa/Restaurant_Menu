using System;
using System.Collections.Generic;

namespace Restaurant_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem newItem1 = new MenuItem(4.99, "Garlic linguine", "Dinner", true);
            MenuItem newItem2 = new MenuItem(6.99, "Really good steak", "Dinner", false);
            MenuItem newItem3 = new MenuItem(2.99, "Delicious wings", "Appetizer", true);

            DateTime today = DateTime.Now;
            List<MenuItem> startingMenu = new List<MenuItem>();

            Menu ourMenu = new Menu(today, startingMenu);

            //adding to the menu (initial menu)
            ourMenu.AddItem(newItem1);
            ourMenu.AddItem(newItem3);
            //how is the menu?
            ourMenu.PrintMenu();
            Console.WriteLine("\n ------------- \n");


            ourMenu.AddItem(newItem2);
            ourMenu.PrintMenu();
            Console.WriteLine("\n ------------- \n");

            ourMenu.PrintItem(newItem3);
            ourMenu.RemoveItem(newItem2);
            Console.WriteLine("\n ------------- \n");

            ourMenu.PrintMenu();




        }
    }
}
