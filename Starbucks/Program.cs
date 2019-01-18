using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer
            {
                Name = "Dillorom",
                Budget = 100,
                FavDrinks = new List<FavDrinks>
                {
                    new FavDrinks
                    {
                        Name = "Latte",
                    },
                    new FavDrinks
                    {
                        Name = "Mocha",
                    }
                },

            });

            customers.Add(new Customer
            {
                Name = "Hassan",
                Budget = 10,
                FavDrinks = new List<FavDrinks>
                {
                    new FavDrinks
                    {
                        Name = "Tea",
                    },
                    new FavDrinks
                    {
                        Name = "Chocolate",
                    }
                },
            });

            Barrista john = new Barrista();

            foreach (var customer in customers)
            {
                var FavDrinksList = john.Greeting(customer.FavDrinks);
                foreach (var drink in FavDrinksList)
                {
                    (bool isAvailable, decimal price) = john.Greeting(customer.FavDrinks.Any()));
                    if (isAvailable)
                    {
                        bool willBuy = customer.WillBuy(price);
                        if (willBuy)
                        {
                            john.Serve(customer.FavDrinks);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, we do not have your {drink} today.");
                    }
                }
               
               
            }

            Console.WriteLine($"All customers served, items left in the inventory is :" +
                $" {john.inventory.drinks.Count}");

            Console.ReadKey();

        }
    }
}
