using System;
namespace Characteredemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Demo Konstruktor ===\n");

            //Instansiasi menggunakan Konstruktor Default
            Player hero1 = new Player();
            hero1.DisplayStatus();

            //Instansiasi menggunakan Konstruktor Berparameter (id dan nama)
            Player hero2 = new Player("C-002", "Emiya");
            hero2.DisplayStatus();

            //Instansiasi menggunakan Konstruktor Berparameter (id, nama, dan kelas)
            Player hero3 = new Player("C-003", "Arthur", "Saber");
            hero3.DisplayStatus();

             Player hero4 = new Player("C-004", "Lancelot", "Lancer", 100, 1);
            hero4.DisplayStatus();
        }
    }
}
