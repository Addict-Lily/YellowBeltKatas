namespace Kata6_ArraysAndLists;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enemies: ");
        string[] enemyNames = new string[5];

        enemyNames[0] = "Goblin";
        enemyNames[1] = "Orc";
        enemyNames[2] = "Troll";
        enemyNames[3] = "Skeleton";
        enemyNames[4] = "Dragon";

        foreach (string enemyArray in enemyNames)
        {
            Console.WriteLine(enemyArray);
        }
        
        
        Console.WriteLine("\nPlayer Inventory: ");
        List<string> playerInventory = new List<string> {"Sword", "Shield", "Potion"};

        foreach (string playerInventoryItem in playerInventory)
        {
            Console.WriteLine(playerInventoryItem);
        }
        
        
        Console.WriteLine("\nUpdated Inventory: ");
        
        playerInventory.Add("Helmet");
        playerInventory.Add("Armor");
        playerInventory.Remove("Potion");
        
        foreach (string playerInventoryItem in playerInventory)
        {
            Console.WriteLine(playerInventoryItem);
        }
        
        Console.WriteLine($"\nTotal Items in Inventory: {playerInventory.Count}");
        
    }
    
}