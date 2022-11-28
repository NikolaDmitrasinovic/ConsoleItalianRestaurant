using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Drinks.IDrinks
{
    internal interface IDrink
    {
        string Name { get; }
        decimal Price { get; }
        decimal Volume { get; }
    }
}
