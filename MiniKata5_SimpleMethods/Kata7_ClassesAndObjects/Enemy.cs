namespace Kata7_ClassesAndObjects;

public class Enemy
{
    public string enemy;
    public int health;

    public Enemy(string enemy, int health)
    {
        this.enemy = enemy;
        this.health = health;
    }

    public void TakeDamage( int damage)
    {
        if (health > 0)
        {
            health -= damage;
            Console.WriteLine($"{enemy} takes {damage} damage. Remaining Health: {health}");
        }
        else
        {
            Console.WriteLine($"{enemy} takes {damage} damage and is defeated");
        }
    }
}