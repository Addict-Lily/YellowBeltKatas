namespace Kata7_ClassesAndObjects;

public class Player
{
    public string nameA;
    public int health;
    public int level;
    public int experience;
    public int damage;
    

    public void Attack(int damage)
    {
        health -= damage;
        Console.WriteLine($"Player {nameA} attacks the Orc and deals {damage} damage.");
    }
    
    public void GainExperience(int exp)
    {
        experience += exp;
        Console.WriteLine($"Player {nameA} gains {experience} experience points.");
            
    }
    


}