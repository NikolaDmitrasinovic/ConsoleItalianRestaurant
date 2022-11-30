using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Kitchen.Drinks.DrinksFactory
{
    internal static class DrinkFactory
    {
        public static List<Drink> MakeDrinksMenu()
        {
            Random rdm = new Random();
            List<Drink> drinksList = new List<Drink>();
            List<string> drinkNamesList = new List<string>();
            string drinkName = "";
            Drink drink;
            int counter = 0;

            do
            {
                switch (rdm.Next(11))
                {
                    case 0: drinkName = "CocaCola"; break;
                    case 1: drinkName = "Sprite"; break;
                    case 2: drinkName = "Fanta"; break;
                    case 3: drinkName = "Cockta"; break;
                    case 4: drinkName = "Pepsi"; break;
                    case 5: drinkName = "Water"; break;
                    case 6: drinkName = "Apple"; break;
                    case 7: drinkName = "Orange"; break;
                    case 8: drinkName = "Lemon"; break;
                    case 9: drinkName = "Strawberries"; break;
                    case 10: drinkName = "Pineapple"; break;
                }

                if (!drinkNamesList.Contains(drinkName))
                {
                    drinkNamesList.Add(drinkName);
                    counter++;
                }
            } while (counter < 3);

            foreach (string name in drinkNamesList)
            {
                if (Enum.IsDefined(typeof(WaterEnum), name))
                {
                    drink = new Water(name, rdm.Next(150, 500), 0.5m);
                }
                else if (Enum.IsDefined(typeof(SodaEnum), name))
                {
                    drink = new Soda(name, rdm.Next(150, 500), 0.5m);
                }
                else
                {
                    drink = new Juce(name, rdm.Next(150, 500), 0.5m);
                }

                drinksList.Add(drink);
            }

            return drinksList;
        }
    }
}
