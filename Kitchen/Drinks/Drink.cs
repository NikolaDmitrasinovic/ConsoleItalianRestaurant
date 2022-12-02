using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Kitchen.Drinks
{
    internal abstract class Drink : IKitchen
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
