using System;
namespace IronNinja
{
    class SweetTooth : Ninja
    {
        public override void Consume(IConsumable item)
        {
            if (IsFull)
            {
                Console.WriteLine($"Too full. Can't consume anymore.");
                return;
            }
            int newCalories = (item.IsSweet) ? item.Calories + 10 : item.Calories;
            calorieIntake += newCalories;
            ConsumptionHistory.Add(item);
            Console.WriteLine("Sweet Tooth consumes - " + item.GetInfo());
        }
        public override bool IsFull
        {
            get { return calorieIntake > 1500; }
        }
    }
}