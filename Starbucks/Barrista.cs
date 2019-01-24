using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks
{
    public class Barrista : Person
    {
        public Inventory inventory;
        public Customer customer;

        public Barrista()
        {
            this.inventory = new Inventory();
            this.customer = new Customer();
        }

        public (bool isAvailable, decimal price) Greeting(List<FavDrinks> favDrinks)
        {
            foreach (FavDrinks d in favDrinks)
            {
                if (inventory.drinks.Any(drink => drink.Name == d.Name))
                {
                    Drink foundDrink = this.inventory.drinks.Where(drink => drink.Name == d.Name).FirstOrDefault();
                    return (true, foundDrink.Price);
                }
                return (false, 0);
            }
            return (true, 10);
        }         

        public  void Serve(List<FavDrinks> favDrinks)
        {
            foreach (var favDrink in favDrinks)
            {
                if (inventory.drinks.Any(drink => drink.Name == favDrink.Name))
                {
                    Drink customerDrink = inventory.drinks.Where(drink => drink.Name == favDrink.Name).FirstOrDefault(); ;
                    inventory.drinks.Remove(customerDrink);
                    Console.WriteLine($"{customerDrink.Name} is served. Items left in the inventory is {inventory.drinks.Count}.");
                 }
            }
        }

        //internal (bool isAvailable, decimal price) Greeting(List<FavDrinks> favDrinks)
        //{
            
        //}
    }
}
