using Drinksmachine.Beverages;
using Drinksmachine.Beverages.Coffees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinksmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee1 = new Coffee();

            // Beverage properties:
            coffee1.Name = "Fourth Expresso";
            coffee1.IsFairTrade = true;

            // Coffee properties
            coffee1.Bean = "Arabica";
            coffee1.Roast = "Dark";
            coffee1.CountryOfOrigin = "Columbia";
        }
    }
}
