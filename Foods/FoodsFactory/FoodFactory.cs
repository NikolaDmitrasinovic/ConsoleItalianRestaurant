using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Foods.FoodsFactory
{
    internal static class FoodFactory
    {
        private static List<Pizza> MakePizzaList()
        {
            Random rdm = new Random();
            List<Pizza> pizzaList = new List<Pizza>();
            List<PizzaEnum> pizzaEnums = new List<PizzaEnum>();
            PizzaEnum name;
            int counter = 0;

            do
            {
                name = (PizzaEnum)rdm.Next(0, 6);                

                if (!pizzaEnums.Contains(name))
                {
                    pizzaEnums.Add(name);
                    counter++;
                }
            } while (counter<4);

            for (int i = 0; i < 4; i++)
            {
                Pizza pizza = new Pizza { Name = pizzaEnums[i].ToString(), Price = rdm.Next(300, 601), SidesList = new List<Side>() };
                pizzaList.Add(pizza);
            }

            return pizzaList;
        }

        private static List<Food> MakePastaList()
        {
            Random rdm = new Random();
            List<Food> pastaList = new List<Food>();
            List<PastaEnum> pastaEnums = new List<PastaEnum>();
            PastaEnum name;
            int counter = 0;

            do
            {
                name = (PastaEnum)rdm.Next(0, 8);

                if (!pastaEnums.Contains(name))
                {
                    pastaEnums.Add(name);
                    counter++;
                }
            } while (counter < 5);

            for (int i = 0; i < 5; i++)
            {
                Pasta pasta = new Pasta { Name = pastaEnums[i].ToString(), Price = rdm.Next(300, 601), SidesList = new List<Side>() };
                pastaList.Add(pasta);
            }

            return pastaList;
        }

        private static List<Side> MakeSideDishesList()
        {
            Random rdm = new Random();
            List<Side> sidesList = new List<Side>();
            List<SideDishEnum> sidesEnum = new List<SideDishEnum>();
            SideDishEnum name;
            int counter = 0;

            do
            {
                name = (SideDishEnum)rdm.Next(0, 8);

                if (!sidesEnum.Contains(name))
                {
                    sidesEnum.Add(name);
                    counter++;
                }
            } while (counter < 5);

            for (int i = 0; i < 5; i++)
            {
                Side sideDish = new Side { Name = sidesEnum[i].ToString(), Price = rdm.Next(20, 101) };
                sidesList.Add(sideDish);
            }

            return sidesList;
        }

        public static List<Food> MenuOfTheDay()
        {
            List<Food> menu = MakePastaList();
            List<Pizza> pizaList = MakePizzaList();
            List<Side> sidesList = MakeSideDishesList();

            foreach (Pizza p in pizaList)
            {
                menu.Add(p);
            }

            foreach (Side s in sidesList)
            {
                menu.Add(s);
            }
            
            return menu;
        }
    }
}
