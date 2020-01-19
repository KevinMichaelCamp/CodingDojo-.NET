using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human myGuy = new Human("Kevin");
            Human badGuy = new Human("Donny");
            Console.WriteLine(myGuy.Health);
            myGuy.Attack(badGuy);
            Console.WriteLine(badGuy.Health);
        }
    }
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get { return health; }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
}
