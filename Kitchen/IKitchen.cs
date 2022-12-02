using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Kitchen
{
    internal interface IKitchen
    {
        public string Name { get;  }
        public decimal Price { get;  }
    }
}
