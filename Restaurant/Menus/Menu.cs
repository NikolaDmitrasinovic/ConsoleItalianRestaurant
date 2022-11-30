using ConsoleItalianRestaurant.Foods.FoodsFactory;
using ConsoleItalianRestaurant.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Restaurant.Menus
{
    internal sealed class Menu
    {
        private static Menu instance = null;
        public static Menu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Menu();
                }
                return instance;
            }
        }

        private List<Food> menu;

        public Menu()
        {
            menu = FoodFactroy.MenuOfTheDay();
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Todays menu ({DateTime.Now:d}):");
            foreach (Food item in menu)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
