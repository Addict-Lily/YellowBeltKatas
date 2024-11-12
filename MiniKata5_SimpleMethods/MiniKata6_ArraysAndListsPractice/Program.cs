namespace MiniKata6_ArraysAndListsPractice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enemies: ");
        
        string[] enemyNames = { "Goblin", "Orc", "Troll"};

        foreach (string enemyName in enemyNames)
        {
            Console.WriteLine(enemyName);
        }
        
        Console.WriteLine("\nPlayer inventory: ");

        List<string> playerInventory = new List<string> {"Sword", "Shield", "Potion"};
        
        foreach (string playersInventories in playerInventory)
        {
            Console.WriteLine(playersInventories);
        }
        
        Console.WriteLine("\nUpdated Inventory: ");

        playerInventory.Add("Helmet");
        
        foreach (string playersInventories in playerInventory)
        {
            Console.WriteLine(playersInventories);
        }
        
    }
}