using System;

namespace IronNinja
{
    class SpiceHound : Ninja
    {
        public override void Consume(IConsumable item)
        {
            if (IsFull)
            {
                Console.WriteLine($"Too full. Can't consume anymore.");
                return;
            }
            int newCalories = (item.IsSpicy) ? item.Calories - 5 : item.Calories;
            calorieIntake += newCalories;
            ConsumptionHistory.Add(item);
            Console.WriteLine("Spice Hound consumes - " + item.GetInfo());
        }
        public override bool IsFull
        {
            get { return calorieIntake > 1200; }
        }
    }
}