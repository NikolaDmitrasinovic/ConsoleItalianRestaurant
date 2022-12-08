using ConsoleItalianRestaurant.Menus.IItems;
using ConsoleItalianRestaurant.Menus.Items;
using ConsoleItalianRestaurant.Menus.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Foods
{
    internal abstract class Food : Item, IItem
    {
        public List<SideDish> SideDishList { get; set; }

        protected Food(string name, double price):base(name, price)
        {
            SideDishList = new List<SideDish>();
        }
    }
}
