namespace Kata10;
public abstract class Character : ITakeDamage
{
    public string Name { get; set; }
    public int Health { get; set; }
    public virtual void Hunt(Character target)
    {
        Console.WriteLine($"{Name} is hunting koje je ime{target.Name}.");
    }
}
public class Player : Character, IWalk, ISpeak
{
    public void Walk()
    {
        Console.WriteLine($"{playerName} is walking...");
    }

    public void Speak()
    {
        Console.WriteLine($"{playerName} is speaking...");
    }
    public override void Hunt(Character target)
    {
        //How to write name of the enemy?
        Console.WriteLine($"{playerName} is hunting {target.Name}...");
        target.Health -= 10;
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