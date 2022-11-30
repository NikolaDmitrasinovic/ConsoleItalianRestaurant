using ConsoleItalianRestaurant.Foods.FoodsFactory;
using ConsoleItalianRestaurant.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleItalianRestaurant.Drinks.DrinksFactory;
using ConsoleItalianRestaurant.Drinks;

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

        private List<Food> foodsMenu;
        private List<Drink> drinksMenu;

        public Menu()
        {
            foodsMenu = FoodFactory.MenuOfTheDay();
            drinksMenu = DrinkFactory.MakeDrinksMenu();
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Todays menu ({DateTime.Now:d}):");
            foreach (Food item in foodsMenu)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (Drink item in drinksMenu)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
