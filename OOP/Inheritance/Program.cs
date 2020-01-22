using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Human me = new Human("Kevin");
            Wizard wizard = new Wizard("Gandalf");
            Ninja ninja = new Ninja("Ralph");
            Samurai samurai = new Samurai("Sam");

            wizard.Attack(me);
            wizard.Heal(me);
            ninja.Attack(wizard);
            ninja.Steal(wizard);
            samurai.Attack(ninja);
            samurai.Meditate();
        }
    }
}
