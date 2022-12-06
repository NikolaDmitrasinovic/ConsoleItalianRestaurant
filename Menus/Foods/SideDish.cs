using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Foods
{
    internal class SideDish : Food
    {
        public SideDish(string name, double price) : base(name, price)
        {
        }

        public override string ToString() => $"SideDish: {Name}....price: {Price}";
    }
}
