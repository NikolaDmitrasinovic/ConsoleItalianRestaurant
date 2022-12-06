using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.IItems
{
    internal interface IItem
    {
        public int Id { get;  }
        public string Name { get;  }
        public double Price { get;  }
    }
}
