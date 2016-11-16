using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fres Norwegian Salmon with Sanderjord butter.", 25.50);
            summerMenu.AddMenuItem("Gawel", "New barabos", 55.50);
            summerMenu.AddMenuItem("Kolo", "Fres Norwegian fgfgfgf with Sanderjord butter.", 26.50);
            summerMenu.HospitalDirections = "Right aroung the corner.Ask for dr watson";

            DrinkMenu outsideDrinks = new DrinkMenu();
            try
            {
                outsideDrinks.Disclaimer = "Dontr drink in work";
                outsideDrinks.AddMenuItem("Lolita", "New barabos", 55.50);
                outsideDrinks.AddMenuItem("Matryca", "Fres Norwegian fgfgfgf with Sanderjord butter.", 26.50);
                outsideDrinks.AddMenuItem("Matryca", "Fres Norwegian fgfgfgf with Sanderjord butter.", 23);
            }
            catch (Exception thrownExeption)
            {
                Console.WriteLine(thrownExeption.Message);
            }
            Order HungryGuestOrder = new Order();

            for(int x = 0; x <= summerMenu.items.Count - 1; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                HungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                HungryGuestOrder.items.Add(currentItem);
            }
            Console.WriteLine("The total is " + HungryGuestOrder.Total);
            Console.ReadKey();
        }
    }
}
