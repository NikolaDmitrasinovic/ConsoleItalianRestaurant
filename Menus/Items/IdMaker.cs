using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleItalianRestaurant.Menus.Items
{
    internal sealed class IdMaker
    {
        private static IdMaker instance = new IdMaker();
        public static IdMaker Instance
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

        private int Id { get; set; }

        private IdMaker()
        {
            Id = 0;
        }

        public int GetId()
        {
            return Id++;
        }
    }
}
