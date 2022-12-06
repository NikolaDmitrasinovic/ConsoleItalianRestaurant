using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Items
{
    internal sealed class IdMaker
    {
        private IdMaker instance = new IdMaker();
        public IdMaker Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new IdMaker();
                }
                return instance;
            }
        }

        private static int id = 0;

        public static int GetId()
        {
            return id++;
        }
    }
}
