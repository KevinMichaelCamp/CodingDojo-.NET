using System;

namespace RPG
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 10, 100) { }

        public void Steal(Enemy target)
        {
            health += base.Attack(target, 5);
            Console.WriteLine($"{Name} steals 5 health from {target.Name}!");
        }
        public override int Attack(Enemy target)
        {
            Random rand = new Random();
            int dmg = Dexterity;
            if (rand.Next(100) <= 20)
            {
                dmg += 10;
            }
            return base.Attack(target, dmg);
        }
    }
}