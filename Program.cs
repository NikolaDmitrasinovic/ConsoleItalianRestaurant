using ConsoleItalianRestaurant.Menus;
using ConsoleItalianRestaurant.Menus.IItems;
using ConsoleItalianRestaurant.Restaurant.Tables;

namespace ConsoleItalianRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Italian Restaurant!");
            Menu ourMenu = new Menu();
            ourMenu.PrintMenu();

            Table table1 = new Table();
            Table table2 = new Table();
            Table table3 = new Table();
            Table table4 = new Table();

            table1.OrderItems.Add(21);
            table1.OrderItems.Add(23);
            table1.OrderItems.Add(17);
            table2.OrderItems.Add(45);

            try
            {
                table1.MakeNewOrder();
            }
            catch (Exception xcp)
            {
                Console.WriteLine(xcp.Message);
            }

            try
            {
                table2.MakeNewOrder();
            }
            catch (Exception xcp)
            {
                Console.WriteLine(xcp.Message);
            }

            table2.OrderItems.Add(60);

            table1.PayLastBill();

            try
            {
                table2.MakeNewOrder();
            }
            catch (Exception xcp)
            {
                Console.WriteLine(xcp.Message);
            }

            table2.PayLastBill();

            try
            {
                table2.MakeNewOrder();
            }
            catch (Exception xcp)
            {
                Console.WriteLine(xcp.Message);
            }
        }
    }
}