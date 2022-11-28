using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Foods.IFoods
{
    internal interface IFood
    {  
        string Name { get; }
        decimal Price { get; }
    }
}
