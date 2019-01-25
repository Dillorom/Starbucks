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
            var inDrinksList = inventory.drinks.Select(d => d.Name).Intersect(favDrinks.Select(d => d.Name));
            var result = inventory.drinks.Where(d => inDrinksList.Contains(d.Name));
            var foundDrink = result.ToList().First();
            return (true, foundDrink.Price);


            //Dictionary<string, double> tracker = new Dictionary<string, double>();
            //foreach (Drink inDrink in inventory.drinks)
            //{
            //    foreach (var favDrink in favDrinks)
            //    {
            //        if (inDrink.Name == favDrink.Name)
            //        {
            //            var foundDrink = favDrink;
            //            return foundDrink;
            //            //tracker.Add(foundDrink.Name, foundDrink.Price); //return (true, foundDrink.Price);
            //        }
            //        return (false, 0);

            //    }
            //    tracker.Intersect(inDrink.Name);
            //return (false, 0);
            //}

            //foreach (FavDrinks d in favDrinks)
            //{
            //    if (inventory.drinks.Any(drink => drink.Name == d.Name))
            //    {
            //        var foundDrink = this.inventory.drinks.FirstOrDefault(drink => drink.Name == d.Name);
            //        return (true, foundDrink.Price);
            //    }
            //    return (false, 0);
            //}
            //return (false, 0);
        }         

        public  void Serve(List<FavDrinks> favDrinks)
        {
            foreach (var favDrink in favDrinks)
            {
                if (inventory.drinks.Exists(drink => drink.Name == favDrink.Name))
                {
                    var customerDrink = inventory.drinks.Where(drink => drink.Name == favDrink.Name).First(); ;
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
