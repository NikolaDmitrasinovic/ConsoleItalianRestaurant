using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleItalianRestaurant.Drinks.DrinksFactory;
using ConsoleItalianRestaurant.Drinks.IDrinks;

namespace ConsoleItalianRestaurant.Drinks
{
    internal abstract class Drink : IDrink
    {
        public string Name { get; }
        public decimal Price { get;}
        public decimal Volume { get;}

        private static List<Drink> menu = DrinkFactory.MakeDrinksMenu();
        
        public Drink(string name, decimal price, decimal volume)
        {
            Name= name;
            Price = price;
            Volume = volume;
        }

        public static void DrinksMenu()
        {
            foreach (Drink item in menu)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
