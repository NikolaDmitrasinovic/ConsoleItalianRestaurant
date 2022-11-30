using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleItalianRestaurant.Kitchen.Drinks.IDrinks;

namespace ConsoleItalianRestaurant.Kitchen.Drinks
{
    internal abstract class Drink : IDrink
    {
        public string Name { get; }
        public decimal Price { get; }
        public decimal Volume { get; }

        public Drink(string name, decimal price, decimal volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
        }
    }
}
