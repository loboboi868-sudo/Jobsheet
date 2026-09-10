using System;
//player
namespace Characteredemo
{
    public class Player
    {
        public string? CharacterId;
        public string? characterName;
        internal string? characterClass;
        public int health;
        public int level;

    //Percobaan2 Konstruktor
    public Player()
        {
            CharacterId = "Unknown";
            characterName = "Hero";
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            Console.WriteLine("Objek dibuat dengan konstruktor default.");
        }
    public Player(string id, string name)
        {
            CharacterId = id;
            characterName = name;
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            Console.WriteLine($"Objek dibuat dengan konstruktor berparameter (id dan nama).");
        }
    public Player(string id, string name, string charClass)
        {
            CharacterId = id;
            characterName = name;
            characterClass = charClass;
            health = 100;
            level = 1;
            Console.WriteLine($"Objek dibuat dengan konstruktor berparameter (id, nama, dan kelas).");
        }
     public Player(string id, string name, string charClass, int initialHealth, int initialLevel)
        {
            CharacterId = id;
            characterName = name;
            characterClass = charClass;
            health = initialHealth;
            level = initialLevel;
            level = 1;
            Console.WriteLine($"Objek dibuat dengan konstruktor berparameter (id, nama, dan kelas).");
        }
    //Method
    public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"Karakter {characterName} (level {level}) memulai petualangan!");
        }
    private void Levelup()
        {
            level ++;
            Console.WriteLine($"{characterName} naik level ke {level}!");
        }
    public void TakeDmg(float dmg)
        {
            health -= (int)dmg;
            Console.WriteLine($"{characterName} menerima {dmg}. Sisa HP: {health}");
                if (health <= 0)
                {
                    Console.WriteLine($"{characterName} telah mati!");
                }
        }
    public void Heal(int healAmount)
        {
            health += healAmount;
            Console.WriteLine($"{characterName} menerima penyembuhan sebesar {healAmount}. Sisa HP: {health}");
        }
    public void DisplayStatus()
        {
            Console.WriteLine("=== Status Karakter ===");
            Console.WriteLine($"ID Karakter: {CharacterId}");
            Console.WriteLine($"Nama Karakter: {characterName}");
            Console.WriteLine($"Kelas Karakter: {characterClass}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {health}");
            Console.WriteLine("=======================");
        }
    }

}

