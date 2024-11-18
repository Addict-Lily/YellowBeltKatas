namespace ExamKata;

public class Game
{
    private Player player;
    private Random random;

    public Game()
    {
        random = new Random();
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        player = new Player(name);
    }
    
    private Player player;
    private Random random;

    public Game()
    {
        random = new Random();
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        player = new Player(name);
    }
    
    private void EncounterEnemy()
    {
        var enemy = new Enemy("Goblin", 30, 5);
        Console.WriteLine($"\nA wild {enemy.Type} appears with {enemy.Health} health and {enemy.Damage} damage!");

        while (enemy.IsAlive() && player.IsAlive())
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack\n2. Heal");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                player.Attack(enemy);
                if (enemy.IsAlive())
                    enemy.Attack(player);
            }
            else if (choice == "2")
            {
                player.Heal();
            }
        }

        if (enemy.IsAlive())
        {
            Console.WriteLine("The enemy was too strong. You were defeated!");
        }
        else
        {
            player.GainExperience(30);
            Console.WriteLine("You defeated the enemy!");
        }
    }

    private void EncounterNPC()
    {
        var npc = new NPC("Villager");
        npc.Speak();
    }

    private void EncounterMerchant()
    {
        var merchant = new Merchant("Merchant");
        merchant.Speak();
        merchant.ShowInventory();

        Console.WriteLine("\nWould you like to buy an item?");
        string itemChoice = Console.ReadLine();
        merchant.BuyItem(itemChoice);
    }
    
    
    
}