using ConsoleItalianRestaurant.Menus.Foods;
using ConsoleItalianRestaurant.Menus.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Items
{
    internal abstract class Item
    {
        public int Id { get;  }
        public string Name { get;  }
        public double Price { get;  }

        protected Item(string name, double price)
        {
            Id = IdMaker.Instance.GetId();
            Name = name;
            Price = price;
        }
    }
}
