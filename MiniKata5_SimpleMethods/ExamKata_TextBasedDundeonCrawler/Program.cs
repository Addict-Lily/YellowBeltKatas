namespace ExamKata_TextBasedDundeonCrawler;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Arin", 100, 1);
        Enemy enemy = new Enemy("Goblin", 50, 20);
        NPC npc = new NPC("NPC", "Welcome to our village");
        Merchant merchant = new Merchant("Merchant", new List<string> { "Sword", "Shield", "Potion" });

        npc.Walk();
        player.Walk();
        npc.Speak("Welcome to our village!");
        Console.WriteLine();
        Console.WriteLine("Enter your name: ");

        string name;
        while (true)
        {
            name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter))
            {
                name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
                break;
            }
            Console.WriteLine("Invalid input! Please enter a valid name (letters only): ");
        }

        Console.WriteLine($"\nWelcome, {name}!");
        Console.WriteLine("A wild Goblin appears!");


        Console.WriteLine("Your battle will start now!");
        Console.WriteLine();

        int playerHealth = 100;
        Console.WriteLine($"Player current health: {playerHealth}");

        int goblinHealth = 100;
        Console.WriteLine($"Goblin current health: {goblinHealth}");

        int playerAttack = 30;
        int playerHealAmount = 20;
        
        Random random = new Random();
        
        while (playerHealth > 0 && goblinHealth > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Warrior choose an action: \n1. Attack\n2. Heal");
            
            string playerChoice = Console.ReadLine().ToLower();
            
            if (playerChoice == "attack" || playerChoice == "1")
            {
                Console.WriteLine("\nWarrior attacks the Goblin!");
                goblinHealth -= playerAttack;
                Console.WriteLine($"Goblin takes {playerAttack} damage.\nGoblin's current health: {goblinHealth}");
            }
            else if (playerChoice == "heal" || playerChoice == "2")
            {
                Console.WriteLine("\nWarrior heals!");
                playerHealth += playerHealAmount;
                Console.WriteLine($"The Warrior restores {playerHealAmount} health.");
            }
            else
            {
                Console.WriteLine("\nInvalid choice! You miss your turn.");
            }

            if (goblinHealth == 0)
            {
                Console.WriteLine($"\nCongratulations! The Warrior has defeated the Goblin!");
                break;
            }
            
            int goblinAttack = random.Next(1, 30);
            Console.WriteLine("\nGoblin attacks the Warrior!");
            playerHealth -= goblinAttack;
            Console.WriteLine($"The Warrior takes {goblinAttack} damage.\nWarrior's current health: {playerHealth}");
            
            if (playerHealth == 0)
            {
                Console.WriteLine($"\nThe Warrior has been defeated by the Goblin!");
                break;
            }
        }
        
    }
}
       