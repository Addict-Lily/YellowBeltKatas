namespace Kata7_ClassesAndObjects;

public class Player
{
    public string nameA;
    public int health;
    public int level;
    public int experience;
    public int damage;

    public Player(string nameA, int health, int level, int experience, int damage)
    {
        this.nameA = nameA;
        this.health = health;
        this.level = level;
        this.experience = experience;
        this.damage = damage;
    }

    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"Player {nameA} attacks the {enemy.enemy} and deals {damage} damage.");
        enemy.TakeDamage(damage);
    }
    
    public void GainExperience(int exp)
    {
        experience += exp;
        Console.WriteLine($"Player {nameA} gains {experience} experience points.");
            
    }
}