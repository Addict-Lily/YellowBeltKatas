namespace MiniKata7_ObjectInstatiation;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.Name = "Arin";
        player.Health = 100;
        player.Level = 1;
        
        Console.WriteLine("Player Info: ");
        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Health: {player.Health}");
        Console.WriteLine($"Level: {player.Level}");


        Enemy enemy = new Enemy();
        enemy.Type = "Goblin";
        enemy.Health = 50;
        enemy.Damage = 10;

        Console.WriteLine("\nEnemy Info:");
        Console.WriteLine($"Type: {enemy.Type}");
        Console.WriteLine($"Health: {enemy.Health}");
        Console.WriteLine($"Damage: {enemy.Damage}");

    }
}