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
                    },
                     new FavDrinks
                    {
                        Name = "Caramel",
                    }
                },

            });

            customers.Add(new Customer
            {
                Name = "Hassan",
                Budget = 12,
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
                List<FavDrinks> FavDrinksList = customer.FavDrinks;

                (bool isAvailable, decimal price) = john.Greeting(customer.FavDrinks);
                if (isAvailable)
                {
                    bool willBuy = customer.WillBuy(price);
                    if (willBuy)
                    {
                        john.Serve(customer.FavDrinks);
                        Console.WriteLine($"{customer.Name}, thank you for your purchase!\n ---Moving to the next customer---");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, {customer.Name}, you do not have enough money to purchase.");
                    }
                }
                else
                {
                    Console.WriteLine($"Sorry {customer.Name}, we do not have your favorite drinks today.\n Moving to the next customer...");
                }
            }
            Console.WriteLine($"All customers served.");

            Console.ReadKey();
        }
    }
}
