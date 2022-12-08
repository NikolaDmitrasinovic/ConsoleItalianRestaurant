using ConsoleItalianRestaurant.Menus.Foods.FoodsFactroy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Foods.FoodsFactory
{
    internal static class FoodFactory
    {
        private static List<Pizza> MakePizzaList()
        {
            Random rdm = new Random();
            List<Pizza> pizzaList = new List<Pizza>();

            int idx = -1;
            List<int> indices = new List<int>();

            while (pizzaList.Count<4)
            {
                do
                {
                    idx = rdm.Next(0, 6);
                } while (idx < 0 && indices.Contains(idx));

                indices.Add(idx);
                pizzaList.Add(new Pizza(((PizzaType)idx).ToString(), rdm.Next(300, 601)));
            }

            return pizzaList;
        }

        private static List<Food> MakePastaList()
        {
            Random rdm = new Random();
            List<Food> pastaList = new List<Food>();
            List<PastaType> pastaTypeList = new List<PastaType>();
            PastaType name;
            int counter = 0;

            do
            {
                name = (PastaType)rdm.Next(0, 8);

                if (!pastaTypeList.Contains(name))
                {
                    pastaTypeList.Add(name);
                    counter++;
                }
            } while (counter < 5);

            for (int i = 0; i < 5; i++)
            {
                Pasta pasta = new Pasta(pastaTypeList[i].ToString(), rdm.Next(300, 601));
                pastaList.Add(pasta);
            }

            return pastaList;
        }

        private static List<SideDish> MakeSideDishList()
        {
            Random rdm = new Random();
            List<SideDish> sideList = new List<SideDish>();
            List<SideDishType> sideTypeList = new List<SideDishType>();
            SideDishType name;
            int counter = 0;

            do
            {
                name = (SideDishType)rdm.Next(0, 8);

                if (!sideTypeList.Contains(name))
                {
                    sideTypeList.Add(name);
                    counter++;
                }
            } while (counter < 5);

            for (int i = 0; i < 5; i++)
            {
                SideDish side = new SideDish(sideTypeList[i].ToString(), rdm.Next(20, 101));
                sideList.Add(side);
            }

            return sideList;
        }

        public static List<Food> AvailableFoods()
        {
            List<Food> foodList = MakePastaList();
            List<Pizza> pizzaList = MakePizzaList();
            List<SideDish> sideList = MakeSideDishList();

            foreach (Pizza p in pizzaList)
            {
                foodList.Add(p);
            }

            foreach (SideDish s in sideList)
            {
                foodList.Add(s);
            }

            return foodList;
        }
    }
}
