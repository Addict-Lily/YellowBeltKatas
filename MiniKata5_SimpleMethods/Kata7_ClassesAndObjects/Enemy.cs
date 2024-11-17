namespace Kata7_ClassesAndObjects;

public class Enemy
{
    public string typeA;
    public int health;
    
    public void TakeDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
            Console.WriteLine($"{typeA} takes {damage} damage. Remaining Health: {health}");
        }
        else
        {
            Console.WriteLine($"{typeA} takes {damage} damage and is defeated");
        }
        
        
            
    }
}