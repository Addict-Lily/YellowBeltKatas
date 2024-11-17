namespace Kata9_ObjectInstantiationWithAdditionalClasses;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Arin", 100, 1);
        Enemy enemy = new Enemy("Goblin", 50, 20);
        NPC npc = new NPC("NPC", "Welcome to our village");
        Merchant merchant = new Merchant("Merchant", new List<string> { "Sword", "Shield", "Potion" });
        
        
        player.Attack(enemy,20);
        npc.Talk();
        merchant.Trade();
    }
}