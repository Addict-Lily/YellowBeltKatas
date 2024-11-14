namespace Kata7_ClassesAndObjects;

public class Enemy
{
    public string TypeA;
    public int Health;
    
    public void TakeDamage(int damage)
    {
        if (Health > 0)
        {
            Health -= damage;
            Console.WriteLine($"{TypeA} takes {damage} damage. Remaining Health: {Health}");
        }
        else
        {
            Console.WriteLine($"{TypeA} takes {damage} damage and is defeated");
        }
        
        
            
    }
}