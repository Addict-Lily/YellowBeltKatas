namespace Kata5_MethodsAndParameters;

class Program
{
    static void Main(string[] args)
    {
        string enemyName = "Goblin";
        int damage = 20;
        AttackEnemy(enemyName, damage);

        string playerName = "Arin";
        int healAmount = 15;
        HealPlayer(playerName, healAmount);
    }
    static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine($"Attacked {enemyName} and dealt {damage}! ");
    }

    static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine($"Player {playerName} healed {healAmount} health points!");
    }
}