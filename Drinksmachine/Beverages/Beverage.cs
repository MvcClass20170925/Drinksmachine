using Drinksmachine.Beverages.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinksmachine.Beverages
{
    public abstract class Beverage
    {
        private struct Item
        {
            public Ingredient Ingredient { get; set; }
            public int Amount { get; set; }

            public Item(Ingredient ingredient, int amount )
            {
                Ingredient = ingredient;
                Amount = amount;
            }
        }

        public string Name { get; set; }

        private List<Item> ingredients = new List<Item>();

        public Beverage(string name)
        {
            Name = name;
        }

        public void AddIngredient( Ingredient ingredient, int amount )
        {
            ingredients.Add(new Item(ingredient, amount));
        }

        public void Make()
        {
            foreach( Item item in ingredients )
            {
                item.Ingredient.Get(item.Amount);
                Console.WriteLine("Got: " + item.Amount + " of " + item.Ingredient.Name);
            }
        }
    }
}
