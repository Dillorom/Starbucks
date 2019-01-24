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
                    Price = 11,

                } ,
                new Drink
                {
                    Name = "Coffee",
                    Quantity = 100,
                    Price = 20
                },
                 new Drink
                 {
                    Name = "Latte",
                    Quantity = 100,
                    Price = 11
                 },
                  new Drink
                {
                    Name = "Mocha",
                    Quantity = 100,
                    Price = 13
                },
                   new Drink
                {
                    Name = "Chocolate",
                    Quantity = 100,
                    Price = 15
                }
            };
        }
       
    }
}
