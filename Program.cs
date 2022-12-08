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
            Menu ourMenu = Menu.Instance;
            ourMenu.PrintMenu();

            Table table1 = new Table();
            Table table2 = new Table();
            Table table3 = new Table();
            Table table4 = new Table();

            table1.OrderItems.Add(1);
            table1.OrderItems.Add(3);
            table1.OrderItems.Add(7);
            table2.OrderItems.Add(1);

            try
            {
                table1.MakeNewOrder();
                table2.MakeNewOrder();
            }
            catch (Exception xcp)
            {
                Console.WriteLine(xcp.Message);
            }

            table2.OrderItems.Add(6);

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