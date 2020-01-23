using System;

namespace RPG
{
    class Enemy
    {
        public string Name;
        public int health;
        // Constructor Method
        public Enemy(string name, int hp)
        {
            Name = name;
            health = hp;
        }

        public void attack(Human target)
        {
            target.health -= 10;
            Console.WriteLine($"{Name} attacks {target.Name} for 10 damage.");
        }

        public void IsDead()
        {
            if (health <= 0)
            {
                Console.WriteLine($"{Name} is dead.");
            }
        }
    }


}