using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        // Constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public bool IsFull
        {
            get
            {
                return calorieIntake > 1200;
            }
        }
        public bool Eat(Food meal)
        {
            if (!IsFull)
            {
                calorieIntake += meal.Calories;
                FoodHistory.Add(meal);
                Console.WriteLine($"Ninja chows down on some {meal.Name}");
            }
            else
            {
                Console.WriteLine("Ninja is too full to eat");
            }
            return IsFull;
        }
    }
}