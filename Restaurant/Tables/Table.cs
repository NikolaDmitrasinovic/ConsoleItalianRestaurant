using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleItalianRestaurant.Menus.IItems;
using ConsoleItalianRestaurant.Restaurant.Bills;
using ConsoleItalianRestaurant.Menus;
using ConsoleItalianRestaurant.Menus.Foods;

namespace ConsoleItalianRestaurant.Restaurant.Tables
{
    internal class Table
    {
        public int Id { get; }
        public List<int> OrderItems { get; set; }
        private List<Bill> Bills { get; set; }

        private static int tableCount = 1;

        public Table()
        {
            OrderItems = new List<int>();
            Bills = new List<Bill>();
            Id = tableCount++;
            Console.WriteLine($"Tablee no.{Id} ready.");
        }        

        public void MakeNewOrder()
        {
            Bill lastBill = Bills.LastOrDefault();

            if (Bills.Count==0 || lastBill.Paid==true)
            {
                List<IItem> items = new List<IItem>();
                Menu menuInst = new Menu();
                foreach (int item in OrderItems)
                {
                    items.Add(menuInst.MenuOfTheDay.SingleOrDefault(p => p.Id == item));
                }
                Bills.Add(new Bill(Id, items));
                OrderItems.Clear();
            }
            else
            {
                throw new Exception("Table has bills pending for payment");
            }
        }

        public void PayLastBill()
        {
            if (Bills.LastOrDefault().Paid == false)
            {
                Bills.LastOrDefault().PayBill();
            }
            else
            {
                Console.WriteLine("All bills paid");
            }
        }
    }
}
