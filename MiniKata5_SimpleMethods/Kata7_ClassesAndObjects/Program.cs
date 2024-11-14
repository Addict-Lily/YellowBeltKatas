namespace Kata7_ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.NameA = "Arin";
        player.Health = 100;
        player.Level = 1;
        player.Experience = 0;
        player.Damage = 20;

        Enemy enemy = new Enemy();
        enemy.TypeA = "Orc";
        enemy.Health = 50;
        

        player.Attack(20);
        
        enemy.TakeDamage(20);
        
        player.GainExperience(50);
    }
}