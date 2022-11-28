using ConsoleItalianRestaurant.Drinks.IDrinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Drinks
{
    internal class Soda : Drink
    {
        public Soda(string name, decimal price, decimal volume) : base(name, price, volume) { }

        public override string ToString()=> $"Soda {Name}, Volume: {Volume}l, Price: {Price}";
    }
}
