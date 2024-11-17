namespace MiniKata7_ObjectInstantiation;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.name = "Arin";
        player.health = 100;
        player.level = 1;
        
        Console.WriteLine("Player Info: ");
        Console.WriteLine($"Name: {player.name}");
        Console.WriteLine($"Health: {player.health}");
        Console.WriteLine($"Level: {player.level}");


        Enemy enemy = new Enemy();
        enemy.type = "Goblin";
        enemy.health = 50;
        enemy.damage = 10;

        Console.WriteLine("\nEnemy Info:");
        Console.WriteLine($"Type: {enemy.type}");
        Console.WriteLine($"Health: {enemy.health}");
        Console.WriteLine($"Damage: {enemy.damage}");

    }
}