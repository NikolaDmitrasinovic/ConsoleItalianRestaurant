using ConsoleItalianRestaurant.Menus.IItems;
using ConsoleItalianRestaurant.Menus.Items;
using ConsoleItalianRestaurant.Menus.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Drinks
{
    internal abstract class Drink : Item, IItem
    {
        public double Volume { get;  }

        protected Drink(string name, double price, double volume):base(name, price)
        {
            Volume = volume;
        }
    }
}
