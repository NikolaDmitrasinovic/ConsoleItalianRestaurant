using ConsoleItalianRestaurant.Menus.IItems;
using ConsoleItalianRestaurant.Menus.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Foods
{
    internal abstract class Food : IItem
    {
        public int Id { get;  }
        public string Name { get;  }
        public double Price { get;  }
        public List<SideDish> SideDishList { get; set; }

        protected Food(string name, double price)
        {
            IdMaker id = IdMaker.Instance;

            Id = id.GetId();
            Name = name;
            Price = price;
            SideDishList = new List<SideDish>();
        }
    }
}
