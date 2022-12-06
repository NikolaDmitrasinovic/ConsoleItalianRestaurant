using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleItalianRestaurant.Menus.IItems;

namespace ConsoleItalianRestaurant.Restaurant.Bills
{
    internal class Bill
    {
        public DateTime Time { get; }
        public int TableId { get;  }
        public List<IItem> Order { get; }
        public double Price { get; }

        private bool paid;
        public bool Paid { get { return paid; } }

        public static List<Bill> AllBills = new List<Bill>();

        public Bill(int tableId, List<IItem> order)
        {
            
            Time = DateTime.Now;
            TableId = tableId;
            Order = order;
            Price = OrderPrice();
            paid = false;
            AllBills.Add(this);
        }

        private double OrderPrice()
        {
            double price = 0;
            foreach (IItem item in Order)
            {
                price += item.Price;
            }
            return price;
        }

        public void PayBill()
        {
            paid = true;
            Console.WriteLine($"Table {TableId} bill: {Price}, paid");
        }
    }
}
