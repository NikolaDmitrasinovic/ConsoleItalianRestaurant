using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleItalianRestaurant.Foods.FoodsFactory;
using ConsoleItalianRestaurant.Foods.IFoods;

namespace ConsoleItalianRestaurant.Foods
{
    internal abstract class Food : IFood
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        private static List<Food> menu = FoodFactroy.MenuOfTheDay();

        public static void FoodsMenu()
        {
            Console.WriteLine($"Todays menu ({DateTime.Now:d}):");
            foreach (Food item in menu)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
