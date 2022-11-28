using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Foods
{
    internal class Pizza : Food
    {
        public override string ToString()=> $"Pizza {Name}, price: {Price}";
    }
}
