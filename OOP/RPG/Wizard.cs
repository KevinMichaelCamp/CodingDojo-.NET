using System;

namespace RPG
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50) { }
        public int Heal(Human target)
        {
            int healAmt = Intelligence;
            target.health += healAmt;
            Console.WriteLine($"{Name} healed {target.Name} adding {healAmt} health!");
            return target.health;
        }
        public override int Attack(Enemy target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            health += dmg;
            Console.WriteLine($"{Name} attacks {target.Name} absorbing {dmg} health!");
            return target.health;
        }
    }
}