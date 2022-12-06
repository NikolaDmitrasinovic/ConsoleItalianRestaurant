using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Foods
{
    internal class Pizza : Food
    {
        public Pizza(string name, double price) : base(name, price)
        {
        }

        public override string ToString() => $"Pizza: {Name}....price: {Price}";
    }
}
