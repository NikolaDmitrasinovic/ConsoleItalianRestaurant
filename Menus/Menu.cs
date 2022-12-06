using ConsoleItalianRestaurant.Menus.Drinks;
using ConsoleItalianRestaurant.Menus.Drinks.DrinksFactory;
using ConsoleItalianRestaurant.Menus.Foods;
using ConsoleItalianRestaurant.Menus.Foods.FoodsFactory;
using ConsoleItalianRestaurant.Menus.IItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus
{
    internal sealed class Menu 
    {
        private static Menu instance = new Menu();
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

        private List<Food> foodMenu = FoodFactory.AvailableFoods();
        private List<Drink> drinkMenu = DrinkFactory.AvailableDrinks();
        public List<IItem> MenuOfTheDay { get; }
        
        public Menu()
        {
            MenuOfTheDay = new List<IItem>();

            foreach (Food item in foodMenu)
            {
                MenuOfTheDay.Add(item);
            }
            foreach (Drink item in drinkMenu)
            {
                MenuOfTheDay.Add(item);
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Todays menu ({DateTime.Now:d}):");
            foreach (IItem item in MenuOfTheDay)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
