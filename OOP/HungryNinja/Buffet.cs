using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;

        // Constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Chicken Wings", 500, true, false),
                new Food("Cheeseburger", 750, false, false),
                new Food("Pizza", 800, false, false),
                new Food("Fries", 250, false, false),
                new Food("Chips & Salsa", 100, true, false),
                new Food("Ice Cream", 250, false, true),
                new Food("Cake", 150, false, true)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}