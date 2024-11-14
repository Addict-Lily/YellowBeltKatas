namespace Kata9_ObjectInstantiationWithAdditionalClasses;

public class Player
{
    public string Name {get; private set;}
    public int Health {get; private set;}
    public int Level {get; private set;} 

    public Player(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }
    public void Attack(Enemy enemy,  int damage)
    {
        Console.WriteLine($"{Name} attacks {enemy.Type} and deals {damage} damage.");
        enemy.TakeDamage(damage);
    }
}