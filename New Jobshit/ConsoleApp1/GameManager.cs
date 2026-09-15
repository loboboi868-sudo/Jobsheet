using System;
namespace Characteredemo
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine($"\nTotal pemain yang dibuat: {Player.GetPlayerCount()}");

            Console.WriteLine("=== Demo Konstruktor ===\n");
            Player hero1 = new Player();
            hero1.DisplayStatus();
            Player hero2 = new Player("C-002", "Emiya");
            hero2.DisplayStatus();
            Player hero3 = new Player("C-003", "Arthur", "Saber");
            hero3.DisplayStatus();
            Player hero4 = new Player("C-004", "Lancelot", "Lancer", 300, 3);
            hero4.DisplayStatus();
            
            Console.WriteLine($"\nTotal pemain yang dibuat: {Player.GetPlayerCount()}");
        }
    }
}
