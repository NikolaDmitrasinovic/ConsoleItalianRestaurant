using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Drinks
{
    internal class Water : Drink
    {
        public Water(string name, decimal price, decimal volume) : base(name, price, volume) { }

        public override string ToString() => $"Water {Name}, Volume: {Volume}l, Price: {Price}";
    }
}
