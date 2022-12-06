using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Drinks.DrinksFactory
{
    internal static class DrinkFactory
    {
        public static List<Drink> AvailableDrinks()
        {
            Random rdm = new Random();
            List<Drink> drinksList = new List<Drink>();
            List<string> drinkNamesList = new List<string>();
            string drinkName = "";
            Drink drink;
            double[] volume = new double[3];
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

            for (int i = 0; i < 3; i++)
            {
                if (rdm.Next(0,2) == 0)
                {
                    volume[i] = 0.3;
                }
                else
                {
                    volume[i] = 0.5;
                }
            }

            foreach (string name in drinkNamesList)
            {
                if (Enum.IsDefined(typeof(WaterType), name))
                {
                    drink = new Water(name, rdm.Next(150, 500), volume[0]);
                }
                else if (Enum.IsDefined(typeof(SodaType), name))
                {
                    drink = new Soda(name, rdm.Next(150, 500), volume[1]);
                }
                else
                {
                    drink = new Juice(name, rdm.Next(150, 500), volume[2]);
                }

                drinksList.Add(drink);
            }

            return drinksList;
        }
    }
}
