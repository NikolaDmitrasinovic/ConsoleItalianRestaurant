using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Kitchen.Foods
{
    internal class Pasta : Food
    {
        public override string ToString() => $"Pasta {Name}, price: {Price}";
    }
}
