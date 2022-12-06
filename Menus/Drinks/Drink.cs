using ConsoleItalianRestaurant.Menus.IItems;
using ConsoleItalianRestaurant.Menus.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Drinks
{
    internal abstract class Drink : IItem
    {
        public int Id { get;  }
        public string Name { get;  }
        public double Price { get;  }
        public double Volume { get;  }

        protected Drink(string name, double price, double volume)
        {
            Id = IdMaker.GetId();
            Name = name;
            Price = price;
            Volume = volume;
        }
    }
}
