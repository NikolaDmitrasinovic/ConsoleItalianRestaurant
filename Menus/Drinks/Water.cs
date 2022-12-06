using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Drinks
{
    internal class Water : Drink
    {
        public Water(string name, double price, double volume) : base(name, price, volume)
        {
        }

        public override string ToString() => $"Water: {Name}, {Volume}l....price: {Price}";
    }
}
