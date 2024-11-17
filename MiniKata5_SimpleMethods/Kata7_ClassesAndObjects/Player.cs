namespace Kata7_ClassesAndObjects;

public class Player
{
    public string nameA;
    public int health;
    public int level;
    public int experience;
    public int damage;

    public Player(string aNameA, int aHealth, int aLevel, int aExperience, int aDamage)
    {
        nameA = aNameA;
        health = aHealth;
        level = aLevel;
        experience = aExperience;
        damage = aDamage;
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