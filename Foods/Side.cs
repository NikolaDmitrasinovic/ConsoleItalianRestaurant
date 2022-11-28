using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleItalianRestaurant.Foods
{
    internal class Side : Food
    {
        public override string ToString() => $"Side dish {Name}, price: {Price}";
    }
}
