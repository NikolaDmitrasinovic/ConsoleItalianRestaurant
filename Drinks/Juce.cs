using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Drinks
{
    internal class Juce : Drink
    {
        public Juce(string name, decimal price, decimal volume) : base(name, price, volume) { }

        public override string ToString() => $"Juce {Name}, Volume: {Volume}l, Price: {Price}";
    }
}
