namespace MiniKata6_ArraysAndListsPractice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enemies: ");
        string[] enemyNames = { "Goblin", "Orc", "Troll"};

        foreach (string enemyArray in enemyNames)
        {
            Console.WriteLine(enemyArray);
        }
        
        
        Console.WriteLine("\nPlayer inventory: ");
        List<string> playerInventory = new List<string> {"Sword", "Shield", "Potion"};
        
        foreach (string playersArray in playerInventory)
        {
            Console.WriteLine(playersArray);
        }
        
        
        Console.WriteLine("\nUpdated Inventory: ");
        playerInventory.Add("Helmet");
        
        foreach (string playerArray in playerInventory)
        {
            Console.WriteLine(playerArray);
        }
    }
}