using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build Heroes
            Ninja ninja = new Ninja("Raphael");
            Samurai samurai = new Samurai("Ryu");
            Wizard wizard = new Wizard("Gandolph");
            // Build Enemies 
            Spider spider1 = new Spider("Arachnick the Spider");
            Spider spider2 = new Spider("Tarantino the Spider");
            Zombie zombie = new Zombie("Fred the Zombie");

            bool gameFinished = false;

            // Intro & Player info
            Console.WriteLine("Welcome to...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("HELL!!!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Please enter your name...");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Hello, {playerName}!");
            Console.WriteLine("You are a party consisting of a Wizard, a Ninja, amd a Samurai.");
            Console.WriteLine("Your party is traveling through another dimension on its way to recover an ancient script.");
            Console.WriteLine("Along the way you encounter 2 zombies and a spider...");


            // Game Play
            while (gameFinished == false)
            {
                Console.WriteLine("Which character would you like to use?");
                Console.WriteLine("1 - Wizard");
                Console.WriteLine("2 - Ninja");
                Console.WriteLine("2 - Samurai");
                string playerChoice = Console.ReadLine();
                if (playerChoice == "1")
                {
                    wizard.Attack(spider1);
                }
                else if (playerChoice == "2")
                {
                    ninja.Attack(spider1);
                }
                else if (playerChoice == "3")
                {
                    samurai.Attack(spider1);
                }
                else
                {
                    Console.WriteLine("Invalid selection :(");

                }
            }







        }
    }
}
