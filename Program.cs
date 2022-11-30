using ConsoleItalianRestaurant.Restaurant.Menus;

namespace ConsoleItalianRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Italian Restaurant!");
            Menu ourMenuOfTheDay = new Menu();
            ourMenuOfTheDay.PrintMenu();
        }
    }
}