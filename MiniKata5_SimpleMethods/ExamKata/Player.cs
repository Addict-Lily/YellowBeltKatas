using System.ComponentModel;

namespace ExamKata;

public class Player : ICombat, ISpeak
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;  // Initial health
        Level = 1;
        Experience = 0;
    }

    public void Attack(ICombat target)
    {
        int damage = 20;  // Example attack damage
        Console.WriteLine($"{Name} attacks for {damage} damage.");
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Health left: {Health}");
    }

    public bool IsAlive() => Health > 0;

    public void Heal()
    {
        Health += 20;  // Heal some health
        Console.WriteLine($"{Name} heals for 20 health. Health now: {Health}");
    }

    public void GainExperience(int points)
    {
        Experience += points;
        Console.WriteLine($"{Name} gains {points} experience.");
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Ready for battle!");
    }
    
}