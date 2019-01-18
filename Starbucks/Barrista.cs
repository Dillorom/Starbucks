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

        public Barrista()
        {
            this.inventory = new Inventory();
        }

        public  (bool isAvailable, decimal price) Greeting(string choice)
        {
            if (this.inventory.drinks.Any(drink => drink.Name == choice))
            {
                Drink foundDrink = this.inventory.drinks.Where(drink => drink.Name == choice).First();
                return (true, foundDrink.Price);
            }
            return (false, 0);
        }

        public void Serve(string choice)
        {
            Drink customerDrink =this.inventory.drinks.Where(drink => drink.Name == choice).First();
            this.inventory.drinks.Remove(customerDrink);
        }

        internal (bool isAvailable, decimal price) Greeting(List<FavDrinks> favDrinks)
        {
            throw new NotImplementedException();
        }
    }
}
