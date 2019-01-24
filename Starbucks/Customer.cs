using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks
{
    public class Customer : Person

    {
        public int Budget { get; set; }
        public List<FavDrinks> FavDrinks { get; set; }

        public Customer()
        {
        }


        public bool WillBuy(decimal price)
        {
            if (this.Budget >= price)
            {
                return true;
            }
            return false;
        }
    }
}
