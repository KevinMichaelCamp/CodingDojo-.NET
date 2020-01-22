using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;

        // Constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Chicken Wings", 500, true, false),
                new Food("Cheeseburger", 750, false, false),
                new Food("Pizza", 800, false, false),
                new Food("Fries", 250, false, false),
                new Food("Chips & Salsa", 100, true, false),
                new Food("Ice Cream", 250, false, true),
                new Food("Cake", 150, false, true),
                new Drink("Lemonade", 50, false),
                new Drink("Milkshake", 100, false),
                new Drink("Bloody Mary", 75, true)
            };
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}