namespace MiniKata5_SimpleMethods;

class Program
{
    static void Main(string[] args)
    {
        int damage = 15;
        Attack(damage);

        int healAmount = 10;
        Heal(healAmount);
    }
    static void Attack(int damage)
    {
        Console.WriteLine($"Player dealt {damage} damage!");
    }
    static void Heal(int healAmount)
    {
        Console.WriteLine($"Player healed {healAmount} health points!");
    }
    
}