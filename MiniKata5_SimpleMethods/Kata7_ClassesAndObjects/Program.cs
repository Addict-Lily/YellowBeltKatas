namespace Kata7_ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.NameA = "Arin";
        player.Health = 100;
        player.Level = 1;
        player.Experience = 100;

        Enemy enemy = new Enemy();
        enemy.TypeA = "Orc";
        enemy.Health = 50;
        enemy.Damage = 20;

        player.Attack();
        player.GainExperience();
        
        enemy.TakeDamage();
    }
}