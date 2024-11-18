namespace Kata10_ExtractingInterfacesToReduceCodeDuplication.Actors;
using Interfaces;
public class Player : IWalk, ISpeak, ITakeDamage
{
    public void Walk()
    {
        Console.WriteLine($"{playerName} walking...");
    }

    public void Speak()
    {
        Console.WriteLine($"{playerName} speaking...");
    }
    public void Hunt()
    {
        //How to write name of the enemy?
        Console.WriteLine($"{playerName} is hunting {GetType().Name}...");
    }
    
    private string playerName;
    private int playerHealth;
    private int level;
    
    
    public Player(string aPlayerName, int aPlayerHealth, int aLevel)
    {
        PlayerName = aPlayerName;
        PlayerHealth = aPlayerHealth;
        Level = aLevel;
    }
    
    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    public int PlayerHealth
    {
        get { return playerHealth; }
        set
        {
            if (value >= 0)
            {
                playerHealth = value;
                
            }
            else
            {
                Console.WriteLine($"{PlayerName}, it seems you're not alive anymore!!");
            }
        }
    }
    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public void Attack(Enemy enemy,  int damage)
    {
        Console.WriteLine($"{PlayerName} attacks {enemy.EnemyType} and deals {damage} damage.");
        enemy.TakeDamage(damage);
    }
}