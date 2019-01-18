using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks
{
    public class Inventory
    {
        public List<Drink> drinks;
        public Inventory()
        {
            this.drinks = new List<Drink>
            {
                new Drink
                {
                    Name = "Tea",
                    Quantity = 100,
                    Price = 10,

                } ,
                new Drink
                {
                    Name = "Coffee",
                    Quantity = 100,
                    Price = 20
                }
            };
        }
       
    }
}
