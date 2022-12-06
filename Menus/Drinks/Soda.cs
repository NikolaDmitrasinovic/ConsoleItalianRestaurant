using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Drinks
{
    internal class Soda : Drink
    {
        public Soda(string name, double price, double volume) : base(name, price, volume)
        {
        }

        public override string ToString() => $"Soda: {Name}, {Volume}l....price: {Price}";
    }
}
