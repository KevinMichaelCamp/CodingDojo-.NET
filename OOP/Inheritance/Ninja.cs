using System;

namespace Inheritance
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100) { }

        public void Steal(Human target)
        {
            health += base.Attack(target, 5);
            Console.WriteLine($"{Name} steals 5 health from {target.Name}!");
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int dmg = Dexterity * 5;
            if (rand.Next(100) <= 20)
            {
                dmg += 10;
            }
            return base.Attack(target, dmg);
        }
    }
}