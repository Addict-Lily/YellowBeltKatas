namespace Kata7_ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Arin", 100, 1, 0, 20);
        Enemy enemy = new Enemy("Orc", 50);

        player.Attack(enemy);
        player.GainExperience(50);
    }
}