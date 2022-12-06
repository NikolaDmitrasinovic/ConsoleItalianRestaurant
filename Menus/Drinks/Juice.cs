using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Drinks
{
    internal class Juice : Drink
    {
        public Juice(string name, double price, double volume) : base(name, price, volume)
        {
        }

        public override string ToString() => $"Juice: {Name}, {Volume}l....price: {Price}";
    }
}
