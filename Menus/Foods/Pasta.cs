using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Foods
{
    internal class Pasta : Food
    {
        public Pasta(string name, double price) : base(name, price)
        {
        }

        public override string ToString() => $"Pasta: {Name}....price: {Price}";
    }
}
