namespace Kata10_ExtractingInterfacesToReduceCodeDuplication;
using Interfaces;
using Actors;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
        NPC npc = new NPC();
        Merchant merchant = new Merchant();
        
        
        player.Walk();
        player.NameOfTheCharacter();
        enemy.TakeDamage();
        npc.Talk();
        merchant.Talk();
        
    }
}