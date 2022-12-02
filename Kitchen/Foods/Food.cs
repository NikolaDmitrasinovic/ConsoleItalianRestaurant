using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Kitchen.Foods
{
    internal abstract class Food : IKitchen
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Side> SidesList { get; set; }
    }
}
