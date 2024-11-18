namespace Kata10_ExtractingInterfacesToReduceCodeDuplication.Interfaces;
using Actors;
//How to write this line correct?
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Arin", 100, 1);
        Enemy enemy = new Enemy("Goblin", 50, 20);
        NPC npc = new NPC("NPC", "Welcome to our village");
        Merchant merchant = new Merchant("Merchant", new List<string> { "Sword", "Shield", "Potion" });
        
        player.Walk();
        player.Speak();
        player.Hunt();
        
        Console.WriteLine();
        
        player.Attack(enemy,20);
        
        Console.WriteLine();
        
        enemy.Hunt();
        
        Console.WriteLine();
        
        npc.Walk();
        npc.Speak();
        Console.WriteLine();
        
        merchant.Speak();
        
    }
}