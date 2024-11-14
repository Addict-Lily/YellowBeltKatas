namespace Kata9_ObjectInstantiationWithAdditionalClasses;

public class Enemy
{
    public string Type { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Type} takes {damage}. Remaining health: {Health}");

    }
       
}