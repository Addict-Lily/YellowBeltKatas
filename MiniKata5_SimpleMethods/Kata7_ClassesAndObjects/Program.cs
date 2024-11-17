namespace Kata7_ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.nameA = "Arin";
        player.health = 100;
        player.level = 1;
        player.experience = 0;
        player.damage = 20;

        Enemy enemy = new Enemy();
        enemy.typeA = "Orc";
        enemy.health = 50;
        

        player.Attack(20);
        enemy.TakeDamage(20);
        player.GainExperience(50);
    }
}